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