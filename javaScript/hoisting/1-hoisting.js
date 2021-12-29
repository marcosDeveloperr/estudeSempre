//hoisting - levantar algo que pode ser variavel ou funcao.


//hoisting variavel
function fn()
{
    console.log(text); //variavel existe com valor undefined
    var text = 'Exemplo'; //variavel sendo definida
    console.log(text);

}

fn();

//hoisting funcao
//chama uma funcao antes de ser declarada
function func()
{
    log('Hoisting da funcao');//chamando a funcao antes da declaracao
    function log(value)
    {
        console.log(value);
    }
}
func();

