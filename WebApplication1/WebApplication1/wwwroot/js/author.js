let upperBtnn =document.getElementById('btnScrolltoTop');



upperBtnn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});

$(document).ready(function () {

let skip = 6;

$(document).on('click', '#authorLoadMore', function () {
    let authorCount = $("#AuthorCount").val();

    $.ajax({
       
        url: '/Author/Load?skip='+skip,
        type: 'Get',
        success: function (res) {
            $("#blogListAll").append(res)
            skip += 6;
            if (skip >= authorCount) {
                $('#authorLoadMore').remove();
            }
        }
    })
});





//search author start
    $(document).on("keyup", "#authorSearchInput", function () {

        $(".author-search-container-search").css("display","block")
        $(".author-search-container-search .author-search-info-row").remove();

        let search = $(this).val().trim();
       
        if (search.length > 0) {
            $(".author-search-container-search i").css("display", "block")
            $.ajax({
                url: "/Author/Search?search=" + search,
                type: "Get",
                success: function (res) {
                    $(".author-search-container-search").append(res)
                }
            })
        }
        else
        {
            $(".author-search-container-search").css("display", "none")
            $(".author-search-container-search").removeClass("specialClass")
        }
    })

    //search author end

    //close search row start

    $(document).on("click", "#authorSearchXXX", function () {
        $(".author-search-container-search").css("display", "none")
        $(".author-search-container-search").removeClass("specialClass")
    })

 //close search row end

    //full ecran click start
    $(document).on("click", "#searchWindowFull", function () {

        $(".author-search-container-search").addClass("specialClass")
    })

    //full ecran click end

 });


//author detail start
let book = document.getElementById('bookButton');
let about = document.getElementById('aboutButton');
let authorBook = document.querySelector('.author-books-text-areaRow')
let authorBio = document.querySelector('.author-bios-text-areaRow')



book.addEventListener('click', function () {
    authorBook.classList.remove('d-none')
    authorBio.classList.add('d-none')
})

about.addEventListener('click', function () {
    authorBook.classList.add('d-none')
    authorBio.classList.remove('d-none')
})


//author detail end