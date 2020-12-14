using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    public class ChatUsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;


        public ChatUsersController(UserManager<AppUser> userManager, AppDbContext db)
        {
            _userManager = userManager;
            _db = db;

        }

        //messagesIndex action-u butun userlerin listini gosterir
        public async Task<IActionResult> MessagesIndex()
        {
            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ExistImage = existUser.Image;
            ViewBag.ExistUser = existUser;
            List<AppUser> users = _userManager.Users.Include(x => x.Messages).ToList();
            List<Conversation> conversations = _db.Conversations.ToList();


            //eger existuser ile diger userlarin conversation-u varsa onlari secirem
            List<AppUser> usersConv = new List<AppUser>();
            foreach (var conversation in conversations)
            {
                foreach (var user in users)
                {
                    if (conversation.AcceptorId == existUser.Id && conversation.SenderId == user.Id ||
                        conversation.SenderId == existUser.Id && conversation.AcceptorId == user.Id)
                    {
                        usersConv.Add(user);
                    }
                }
            }

            //exist conversationlar
            //her userin exist userla son mesajina catmaq ucun
            List<Conversation> EachConv = new List<Conversation>();
            foreach (var conversation in conversations)
            {
                foreach (var user in users)
                {
                    if (conversation.AcceptorId == existUser.Id && conversation.SenderId == user.Id ||
                        conversation.SenderId == existUser.Id && conversation.AcceptorId == user.Id)
                    {
                        EachConv.Add(conversation);
                    }
                }
            }



            List<Message> messages = _db.Messages.ToList();

            ChatVM homeVM = new ChatVM
            {
                Users = usersConv,
                EachConv = EachConv,
                Messages = messages
            };

            return View(homeVM);
        }

        //bu action userlara aid mesajlari gostermek ucundur
        public async Task<IActionResult> MessageList(string id)
        {
            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ExistUserId = existUser.Id;
            ViewBag.ExistImage = existUser.Image;

            List<AppUser> users = _userManager.Users.ToList();
            List<Conversation> conversations = _db.Conversations.Where(x => x.AcceptorId == existUser.Id || x.SenderId == existUser.Id).ToList();

            //eger existuser ile diger userlarin conversation-u varsa onlari secirem
            List<AppUser> usersConv = new List<AppUser>();
            foreach (var conversation in conversations)
            {
                foreach (var u in users)
                {
                    if (conversation.AcceptorId == existUser.Id && conversation.SenderId == u.Id ||
                        conversation.SenderId == existUser.Id && conversation.AcceptorId == u.Id)
                    {
                        usersConv.Add(u);
                    }
                }
            }


            //existuserin qarsisindaki user
            AppUser user = _userManager.Users.FirstOrDefault(x => x.Id == id);

            if (user == null) return NotFound();
            ViewBag.UserName = user.UserName;
            ViewBag.UserImage = user.Image;
            ViewBag.UserFullName = user.FullName;
            ViewBag.UserBirth = user.BirthDate.ToString("dd/MM/yyyy");
            ViewBag.Religion = user.Religion;
            ViewBag.Bio = user.Bio;

            //her iki userin oldugu conversation tapiram
            Conversation conv = _db.Conversations.Where(x => x.AcceptorId == existUser.Id && x.SenderId == user.Id ||
                                                                 x.AcceptorId == user.Id && x.SenderId == existUser.Id)

                                                               .FirstOrDefault();



            //eger conversation yoxdursa tezsini yaradir
            if (conv == null)
            {
                Conversation newConv = new Conversation
                {
                    SenderId = existUser.Id,
                    AcceptorId = user.Id
                };
                _db.Conversations.Add(newConv);
                await _db.SaveChangesAsync();

                ChatVM home = new ChatVM
                {
                    Users = _userManager.Users.ToList(),
                };

                return View(home);
            }

            //tapdigim converstionda sohbet eden iki user-in mesajlarini tapiram
            //qarsidaki user exist userin smslerini oxusa existuserin smslerinin isRead-i true olur

            List<Message> messages = _db.Messages.Where(x => x.ConversationId == conv.Id).ToList();

            //qarsidaki userin en son mesajini tapiram
            //ondan once qarsidaki userin butun mesajlarin isread-i false edirem
            Message lastmessage = messages.Where(x => x.AppUserId == user.Id).OrderByDescending(x => x.Id).Take(1).FirstOrDefault();
            List<Message> andUserMessages = _db.Messages.Where(x => x.AppUserId == user.Id).ToList();
            if (andUserMessages != null)
            {
                foreach (var aUmsg in andUserMessages)
                {
                    aUmsg.IsRead = false;
                    await _db.SaveChangesAsync();
                }
            }
            if (lastmessage != null)
            {
                lastmessage.IsRead = true;
                await _db.SaveChangesAsync();
            }

            ChatVM homeVM = new ChatVM
            {
                Users = usersConv,
                Messages = messages,
            };

            return View(homeVM);
        }

        //mesaj create elemek ucun
        [HttpPost]
        public async Task<IActionResult> MessageList([FromForm] ChatVM homeVM)
        {
            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser acceptorUser = _userManager.Users.Where(x => x.UserName == homeVM.AcceptorUser).FirstOrDefault();

            //her iki userin oldugu conversation tapiram
            Conversation conv = _db.Conversations.Where(x => x.AcceptorId == existUser.Id && x.SenderId == acceptorUser.Id ||
                                                                 x.AcceptorId == acceptorUser.Id && x.SenderId == existUser.Id)
                                                                .FirstOrDefault();
            //gelen homeVM-deki mesaja conversation id verib yaddasda saxayiram
            Message message = new Message
            {
                ConversationId = conv.Id,
                AppUserId = existUser.Id,
                Content = homeVM.Content,
                dateTime = DateTime.Now

            };

            if (message.Content != null)
            {
                _db.Messages.Add(message);
                await _db.SaveChangesAsync();
            }

            //return RedirectToAction("MessageList", new { id = acceptorUser.Id });
            return Ok(new { message = message.Content, appUserId = message.AppUserId });
        }

        //mesajlari silmek ucun
        public async Task<IActionResult> DeleteMessage(int? id)
        {
            if (id == null) return NotFound();
            Message message = await _db.Messages.FindAsync(id);
            _db.Messages.Remove(message);
            await _db.SaveChangesAsync();

            ////gelen mesajin id-sine gore qarsidaki useri tapib id-sini redirect edirem
            //Conversation conversation = _db.Conversations.Where(x => x.Id == message.ConversationId).FirstOrDefault();
            //AppUser userOne = _userManager.Users.Where(x => x.Id == conversation.AcceptorId).FirstOrDefault();
            //AppUser userTwo = _userManager.Users.Where(x => x.Id == conversation.SenderId).FirstOrDefault();
            //AppUser existUser = _userManager.Users.Where(x => x.Id == message.AppUserId).FirstOrDefault();

            //if (existUser==userOne)
            //{
            //    return RedirectToAction("MessageList",new {id=userTwo.Id});
            //}
            //else
            //{
            //    return RedirectToAction("MessageList", new { id = userOne.Id });
            //}
            return NoContent();
        }

        //userlar-i axtarmaq ucun
        public IActionResult Search(string search)
        {
            IEnumerable<AppUser> users = _db.Users.Where(b => b.UserName.Contains(search)).OrderByDescending(x => x.Id).Take(14);

            return PartialView("_UserSearchPartial", users);
        }

        //iki user arasinda conversation yaratmaq ucun
        public async Task<IActionResult> CreateConversation(string id)
        {
            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser user = await _userManager.FindByIdAsync(id);

            Conversation conversation = _db.Conversations.Where(x => x.AcceptorId == existUser.Id && x.SenderId == user.Id ||
               x.SenderId == existUser.Id && x.AcceptorId == user.Id).FirstOrDefault();
            if (conversation != null)
            {

                return RedirectToAction("MessageList", new { id = user.Id });
            }
            else
            {
                Conversation newConversation = new Conversation
                {
                    SenderId = existUser.Id,
                    AcceptorId = user.Id
                };
                _db.Conversations.Add(newConversation);
                await _db.SaveChangesAsync();
                return RedirectToAction("MessageList", new { id = user.Id });
            }

        }

        //conversation ve mesajlari tam silmek ucun

        public async Task<IActionResult> RemoveConversation(string id)
        {
            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser user = await _userManager.FindByIdAsync(id);

            Conversation conversation = _db.Conversations.Where(x => x.AcceptorId == existUser.Id && x.SenderId == user.Id ||
               x.SenderId == existUser.Id && x.AcceptorId == user.Id).FirstOrDefault();

            List<Message> messages = _db.Messages.Where(x => x.ConversationId == conversation.Id).ToList();

            foreach (var msg in messages)
            {
                _db.Messages.Remove(msg);
            }
            _db.Conversations.Remove(conversation);
            await _db.SaveChangesAsync();

            return RedirectToAction("MessagesIndex");
        }


        public async Task<IActionResult> IsLiked(int? id)
        {
            Message message = await _db.Messages.FindAsync(id);
            if (message.IsLiked == false)
            {
                message.IsLiked = true;
                await _db.SaveChangesAsync();
            }
            else
            {
                message.IsLiked = false;
                await _db.SaveChangesAsync();
            }
            return Ok(new { isLike = message.IsLiked });
        }
    }
}