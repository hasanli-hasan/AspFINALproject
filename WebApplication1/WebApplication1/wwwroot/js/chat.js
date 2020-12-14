//search input click change html start

$(document).ready(function () {

    $(document).on("click", "#userSrcForMsg", function () {
        $("#userSrcForMsg").addClass("click-search-input");
        $(".fas.fa-search").addClass("click-search-input-i")
        $("#timesCircle").show();
    })

    $(document).on("click", "#timesCircle", function () {
        $("#userSrcForMsg").removeClass("click-search-input");
        $(".fas.fa-search").removeClass("click-search-input-i")
        $("#timesCircle").hide();
        $("#userSrcForMsg").val() = "";
    })

    $(".users-search-header-row").mouseleave(function () {
        $("#userSrcForMsg").removeClass("click-search-input");
        $(".fas.fa-search").removeClass("click-search-input-i")
        var valu = $("#timesCircle").hide();
        valu == "";
    });

    //user search start
    $(document).on("keyup", "#userSrcForMsg", function () {
        //loading
        $("#searchSpinner").css("display", "block");
        $("#timesCircle").css("display", "none");

        $(".SearchUserApend-row").css("display", "block");
        $(".SearchUserApend-row .searchUser-info-row").remove();

        let search = $(this).val().trim();

        if (search.length > 0) {

            $.ajax({
                url: "/ChatUsers/Search?search=" + search,
                type: "Get",
                success: function (res) {

                    $(".SearchUserApend-row").append(res)

                    //loading
                    $("#searchSpinner").css("display", "none");
                    $("#timesCircle").css("display", "block");
                }
            })

        }
        else {
            $(".SearchUserApend-row").css("display", "none")

            //loading
            $("#searchSpinner").css("display", "none");
            $("#timesCircle").css("display", "block");
        }

    });

    //message like start ajax

    $(document).on("click", "#isliked", function (e) {

        let id = $(this).attr("data-id");

        $.ajax({
            url: "/ChatUsers/IsLiked?Id=" + id,
            type: "Get",
            success: function (res) {
                let lorem = res.isLike
                if (lorem == true) {
                    e.target.parentElement.nextElementSibling.innerHTML = '<i id="heartIcon" class="fas fa-heart"></i>'

                } else {
                    e.target.parentElement.nextElementSibling.innerHTML = '<i id="heartIcon" class="fas "></i>'

                }
            }

        });
    });

    //message like end

    //mesajin yazilma tarixini gosterir
    $("time.timeago").timeago();


    //message remove ajax start
    $(document).on("click", "#removeUserMessage", function () {
        let id = $(this).attr("data-id");

        $.ajax({
            url: "/ChatUsers/DeleteMessage?Id=" + id,
            type: "Get",
            success: function (res) {

            }
        });

        $(this).closest('#existMessageP').remove()
    });
    //message remove ajax end


    //message create ajax start

    $(document).on("click", "#sendMessageBtn", function (event) {
        event.preventDefault();
        var message = $("#mytextarea").val()
        var acceptorUser = $("#acceptorUserInput").val()


        let homeVM = new FormData();

        homeVM.append("Content", message);
        homeVM.append("AcceptorUser", acceptorUser);

        axios.post('/ChatUsers/MessageList', homeVM)
            .then(function (res) {


                var msgDiv = document.getElementById("msgBoxmsg");

                var message =
                    `
                          <div id="ExistUserMessage">
                             <p id="existMessageP">
                                  <a id="isliked" data-id="@msg.Id">${res.data.message} </a>

                                  <a id="removeUserMessage" data-id="@msg.Id">
                                        <i id="faTimes" class="fas fa-times"></i>
                                   </a>

                              </p>
                           </div>
                      `


                if (message != null) {

                    msgDiv.innerHTML += message;

                }

                $("#mytextarea").val('');

                // her zaman reflesde bu elementin scrollu en altda olur
                var myDiv = document.getElementById("msgBoxmsg");
                myDiv.scrollTop = myDiv.scrollHeight;
            })


    });

    //message create ajax end

 

// her zaman reflesde bu elementin scrollu en altda olur
    var myDiv = document.getElementById("msgBoxmsg");
    myDiv.scrollTop = myDiv.scrollHeight;
});



function openfileDialog() {
    $("#fileLoader").click();
}
