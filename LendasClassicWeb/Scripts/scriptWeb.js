// <!-- Initialize Swiper -->
var swiper = new Swiper(".mySwiper", {
    slidesPerView: 3,
    centeredSlides: true,
    spaceBetween: 30,
    loop: true,
    pagination: {
        el: ".swiper-pagination",
        type: "fraction",
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

var appendNumber = 4;
var prependNumber = 1;
document
    .querySelector(".prepend-2-slides")
    .addEventListener("click", function (e) {
        e.preventDefault();
        swiper.prependSlide([
            '<div class="swiper-slide">Slide ' + --prependNumber + "</div>",
            '<div class="swiper-slide">Slide ' + --prependNumber + "</div>",
        ]);
    });
document
    .querySelector(".prepend-slide")
    .addEventListener("click", function (e) {
        e.preventDefault();
        swiper.prependSlide(
            '<div class="swiper-slide">Slide ' + --prependNumber + "</div>"
        );
    });
document
    .querySelector(".append-slide")
    .addEventListener("click", function (e) {
        e.preventDefault();
        swiper.appendSlide(
            '<div class="swiper-slide">Slide ' + ++appendNumber + "</div>"
        );
    });
document
    .querySelector(".append-2-slides")
    .addEventListener("click", function (e) {
        e.preventDefault();
        swiper.appendSlide([
            '<div class="swiper-slide">Slide ' + ++appendNumber + "</div>",
            '<div class="swiper-slide">Slide ' + ++appendNumber + "</div>",
        ]);
    });

// botao voltar para cima

// Get the button:
let mybutton = document.getElementById("myBtn");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}


//login
function logar() {
    var nome = document.getElementById('nome').value
    var senha = document.getElementById('senha').value

    if (nome == 'admin' && senha == 'eric') {

        location.href = "https://www.youtube.com/watch?v=62JPlUQClMo";

    }
    else {
        alert('Usuário e/ou senha Incorretos')
    }
}

// Cadastros

//Contato
function mascara_celular() {
    var celular = document.getElementById('celular')
    if (celular.value.length == 8) {
        celular.value += "-"
    }
    if (celular.value.length == 2) {
        celular.value += " "
    }
}

  //Agende
