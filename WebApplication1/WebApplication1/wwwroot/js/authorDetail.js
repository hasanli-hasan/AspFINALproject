
//author detail start
let book = document.getElementById('bookButton');
let about=document.getElementById('aboutButton');
let authorBook=document.querySelector('.author-books-text-areaRow')
let authorBio=document.querySelector('.author-bios-text-areaRow')



book.addEventListener('click',function(){
     authorBook.classList.remove('d-none')
     authorBio.classList.add('d-none')
})

about.addEventListener('click',function(){
    authorBook.classList.add('d-none')
    authorBio.classList.remove('d-none')
})


//author detail end