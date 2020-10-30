let upperBtnn =document.getElementById('btnScrolltoTop');



upperBtnn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});

let skip = 6;

$(document).on('click', '#authorLoadMore', function () {
    let authorCount = $("#AuthorCount").val();
    console.log('/Author/Load?skip=' + skip)
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