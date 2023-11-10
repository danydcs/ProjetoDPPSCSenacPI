// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validaNome()
{
    if(document.getElementById('nome').value.length < 3)
    {
        alert("O nome precisa ter ao menos 3 caracteres.")
        document.getElementById("nome").style.color="red";
        return false;
    }
    else
    {
        document.getElementById("nome").style.color="black";
        return true;
    }
}

function validaCel()
{
    if(document.getElementById('telefone').value.length !== 11)
    {
        alert("Favor digitar um número de celular válido")
        document.getElementById("telefone").style.color="red";
        return false;
    }
    else
    {
        document.getElementById("telefone").style.color="black";
        return true;
    }
}

function validaEmail()
{
    var email = document.getElementById("email");

    if(email.value == "" || email.value.indexOf('@') == -1 || email.value.indexOf('.') == -1)
    {
        alert("Por favor, insira um email válido!");
        document.getElementById("email").style.color="red";
    }
    else
    {
        document.getElementById("email").style.color="black";

    }
} 

var slideIndex = 1;
var slideIndex2 = 0;

showSlidesAutomatic();

function plusSlides(n){

    showSlides(slideIndex += n)

}

function currentSlide(n){

    showSlides(slideIndex = n)
}

function showSlides(n){

    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");

    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) {slideIndex = slides.length }

    for (i = 0; i < slides.length; i++) {

        slides[i].style.display = "none";
    }

    for (i = 0; i < dots.length; i++) {

        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex - 1].style.display="block";
    dots[slideIndex - 1].className += " active";

}

function showSlidesAutomatic(){

    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");

    for (i = 0; i < slides.length; i++) {

        slides[i].style.display = "none";
    }

    slideIndex2++;

    if(slideIndex2 > slides.length) { slideIndex2 = 1 }

    for (i = 0; i < dots.length; i++) {

        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex2 - 1].style.display="block";
    dots[slideIndex2 - 1].className += " active";

    setTimeout(showSlidesAutomatic, 3500)

}
