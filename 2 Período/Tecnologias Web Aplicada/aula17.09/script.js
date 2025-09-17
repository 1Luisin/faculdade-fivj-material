function modoEscuro(){
    const corpo = document.querySelector('body');
    corpo.classList.toggle('dark-mode');
}

const titulo1 = document.querySelector('h1');
const titulo2 = document.querySelector('h2');

titulo1.addEventListener("click", ()=>{
    console.log('clicou.');
})

// ou

function clicouRetornou(){
    console.log('clicou no h2');
}

titulo2.addEventListener("click",clicouRetornou());

// clicar no link

const link = document.querySelector('a'); //

link.addEventListener("click", () => {
    console.log('clicou no link');
})