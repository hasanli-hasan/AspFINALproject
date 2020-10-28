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



upperBtn.addEventListener("click",function(){
window.scrollTo({
    top:0,
    left:0,
    behavior:"smooth"
})
});