var swiper = new Swiper('.swiper-container', {
    effect: 'coverflow',
    grabCursor: true,
    slidesPerView: 'auto',
    coverflowEffect: {
      rotate: 40,
      stretch: 0,
      depth: 100,
      modifier: 1,
      slideShadows:true,
    },
    pagination: {
      el: '.swiper-pagination',
    },
  });


  let upperBtn =document.getElementById('btnScrolltoTop');



  upperBtn.addEventListener("click",function(){
  window.scrollTo({
      top:0,
      left:0,
      behavior:"smooth"
  })
  });


//blog search start jquery

$(document).ready(function () {

    $(document).on("keyup", "#blogSearchInput", function () {
        $(".blog-search-container-search").css("display", "block")
        $(".blog-search-container-search .blog-search-info-row").remove();
        let search = $(this).val().trim();
      

        if (search.length > 0) {
          
            $.ajax({
                url: "/Blog/Search?search=" + search,
                type: "Get",
                success: function (res) {

                    $(".blog-search-container-search").append(res)
                }
            })
        } else

        {
            $(".blog-search-container-search").css("display", "none")
            $(".blog-search-container-search").removeClass("specialBlgClass")
        }

    });

    //blog search end

    //close search row start

    $(document).on("click", "#blogContDelete", function () {
        $(".blog-search-container-search").css("display", "none")
        $(".blog-search-container-search").removeClass("specialBlgClass")
    })

    //close search row end

    //full ecran click start
    $(document).on("click", "#blogWindowFull", function () {

        $(".blog-search-container-search").addClass("specialBlgClass")
    })

    //full ecran click end

});