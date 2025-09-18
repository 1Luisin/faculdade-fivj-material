function modoEscuro(){
    const corpo = document.querySelector('body');
    corpo.classList.toggle('dark-mode');
}

const titulo1 = document.querySelector('h1');
const titulo2 = document.querySelectorAll('h2');

titulo1.addEventListener("click", ()=>{
    console.log('clicou.');
})

// ou

function clicouRetornou(){
    console.log('clicou no subtitulo');
}

titulo2.forEach(titulo2 => {
    subtitulo.addEventListener('click',(event) =>{
        
        console.log('clicou no',event.target)
    });
});


// clicar no link

const link = document.querySelector('a'); //

link.addEventListener("click", (event) => {
    event.preventDefault();
    console.log(event.target);
    console.log('clicou no link');
})

const modoescuro = document.querySelector('modo-escuro')
modoescuro.addEventListener("click", () =>{
    document.
})