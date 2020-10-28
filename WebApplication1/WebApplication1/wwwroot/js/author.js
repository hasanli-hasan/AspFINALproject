let upperBtn =document.getElementById('btnScrolltoTop');



upperBtn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});