$('.carousel').carousel({
    interval: 3000
    
  });


  //timely modal info start

  $(document).ready(function(){

    function ShowWindow(){
       $('#main').show();
       //$('html body').css('overflow','hidden');

       setTimeout(hideWindow,20000)
    }
    //ShowWindow()

    function hideWindow(){
      $('#main').hide();
      //$('html body').css('overflow','scroll');
    }

   // hideWindow()

   setTimeout(ShowWindow,10000)
   
   $('#close-btn-btn').click(function(){
    hideWindow()
   })
  });

  //timely info modal end

  let upperBtn =document.getElementById('btnScrolltoTop');

//window upper icon start

upperBtn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});

//window upper icon end

//book search jquery start

$(document).ready(function () {

    $(document).on("keyup", "#bookSearchInput", function () {
        let search = $(this).val().trim();
        $(".bk-search-container-search .bk-search-info-row").remove();
        $(".bk-search-container-search").css("display", "block")
        
        if (search.length > 0) {
            $.ajax({
                url: "/Book/Search?search=" + search,
                type: "Get",
                success: function (res) {
                    $(".bk-search-container-search").append(res)

                }
            })
        }
        else
        {
            $(".bk-search-container-search").css("display", "none")
            $(".bk-search-container-search").removeClass("specialbkClass")
        }


    });

    //close search row start

    $(document).on("click", "#bookTimes", function () {
        $(".bk-search-container-search").css("display", "none")
        $(".bk-search-container-search").removeClass("specialbkClass")
    })

    //close search row end

    //full ecran click start
    $(document).on("click", "#bookExpand", function () {

        $(".bk-search-container-search").addClass("specialbkClass")
    })

    //full ecran click end



});


//add-basket ajax start

$(document).ready(function () {
    $(document).on("click", ".addBasket-Books", function () {
        let id = $(this).attr("data-id");

        $.ajax({
            url: "/Home/AddBasket?Id=" + id,
            type: "Get",
            success: function (res) {
                //$(".basket-products-container").append(res);

                $(".basket-booksCountt").text(res)

                function ShowWindow() {
                    $('.succesfully-alert').show();

                    setTimeout(hideWindow, 830)
                }

                function hideWindow() {
                    $('.succesfully-alert').hide();
                }

                setTimeout(ShowWindow, 140)
            }
        });

    });

});

//add-basket ajax end