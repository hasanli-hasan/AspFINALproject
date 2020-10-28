
//owl carousel start

$('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav:true,
    autoplay:true,
    autoplayTimeout:2000,
    autoplayHoverPause:true,
    responsive:{
        0:{
            items:1
        },
       
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})

// owl carousel end

//Modal Start

let btn =document.getElementById("modal-btn")
let modal=document.getElementById("discountModal")
let closed=document.getElementById("modalClose")
let bookAnimate=document.getElementById("bookAnimate")

btn.onclick = function(){OpenModal()};
function OpenModal(){
    modal.classList.add("discount-modal-container")
    closed.classList.add("fa-times")
    bookAnimate.classList.remove("d-none")
}

closed.onclick = function(){CloseModal()};
function CloseModal(){
    modal.classList.remove("discount-modal-container")
    closed.classList.remove("fa-times")
    bookAnimate.classList.add("d-none")
}

let old = $('.bookAnimation-Card').get(0);
$('.bookAnimation-Card').click(function(){
  if(old!=null && $(old).hasClass('open'))
    $(old).toggleClass('open');
   $(this).toggleClass('open');
   old = this;

})

//Modal End

let upperBtn =document.getElementById('btnScrolltoTop');



upperBtn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});
