var a = 1;
var b = 2;

if(a==b)
{
    a=11; //atualizando o valor variavel global
    let b = 13; //atualizando o valor variavel local

    //estou dentro do bloco de codigo
    console.log(a);// valor glogal a=11
    console.log(b);//valor local b=13;

}

console.log(a); //fora do bloco, tendo variavel global a=11
                //porque foi atualizando o valor 

console.log(b); //valor global b=2;, valor 13 apenas dentro do bloco.

/**
 * Artigo
        Atribuir, colocar um valor em variavel antes de declara a variavel!!
        hoisting
*/

numeroTreze = 13; //reconhece como variavel global
console.log(numeroTreze);

var nome = "Marcos";
var sobreNome = "Tav"; //variavel global

if(nome === "Marcos")
{
    var nome = "Lucio";
    let sobreNome = "Mora"; //variavel local
    console.log(sobreNome);
}
console.log(nome,sobreNome);

// Constantes em SNAKE_UPPER_CASE
const NOME_COMPLETO = "marcos tavares"; //precisa ser inicializado.
console.log(NOME_COMPLETO);

//conceito de dinâmico
let valorSorte = "13"; //tipo string
console.log(typeof(valorSorte));
valorSorte = 12; //tipo inteiro
console.log(typeof(valorSorte)); //dinamico - string passou para number

//tipos primitivos nao tem metodos dentro deles.
//sao escritos em letras minusculas 