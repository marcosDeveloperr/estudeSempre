//console.log('marcos');

function soma(a,b)
{
    return a+b;
}

//repare que sempre estar com o primeiro parametro 5
console.log(soma(5,8));
console.log(soma(5,7));
console.log(soma(5,6));
console.log(soma(5,5));

//utilizando a tecnica currying
function som(a)
{
    return function(b)
    {
        return a+b;
    }
}

//sempre o primeiro parametro é 2
//primeiro parametro memorizado.
const som2 = som(2) 

//colocando o valor do segundo parametro
console.log(som2(10));
console.log(som2(20));