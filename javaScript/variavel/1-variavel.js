//variavel
//var - nao respeita escopo de bloco
//let 
//const

var nomeVar = 'Marcos';
let nomeLet = 'Marcos';
const nomeConst = 'Marcos';

console.log('var: ' + nomeVar);
console.log('let: ' + nomeLet);
console.log('const: ' + nomeConst);

//escopo global
{
    //escopo bloco
}

function test()
{
    //escopo de funcao
}

//escopo global
console.log('\n escopo global');
var teste = 'example';
(()=>{
    console.log(`valor dentro da funcao "${teste}"`);
    if(true)
    {
        var teste = 'Example';
        console.log(`valor dentro do if "${teste}"`);
    }
    console.log(`valor após a execução do if "${teste}`);
})();

console.log('\n escopo local');
//escopo bloco
(()=>{
    let teste = "example";
    console.log(`valor dentro da funcao "${teste}"`);
    if(true)
    {
        let teste = "valor dentro if";
        console.log(`valor dentro do if "${teste}"`);
    }
    console.log(`valor após a execução do if "${teste}"`)
})();