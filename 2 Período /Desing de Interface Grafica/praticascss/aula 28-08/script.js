var arroz = (d,e,f)=>{var coco = d + e + f};

function somar3Numeros(a,b,c){
    var resultado = a + b + c;
    return resultado;
}

function somar2Numeros(a,b){
    return a + b;
}

/*
FUNÇÃO DE CALLBACK
*/

function imprimeSoma(n1, n2, n3, funcao,arroz){
    var soma = funcao(n1,n2,n3);
    console.log(soma);

}

imprimeSoma(1,2,3,somar3Numeros);