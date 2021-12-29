//retorna um tamanho de uma string
const textoSize = 'texto'.length;
console.log(`\nQuantidade de letras: ${textoSize}`);

//retorna um array quebrando a string por um delimitador
const splittedText = 'texto'.split('x');
console.log('\nArray com as posições separadas pelo delimitador: ', splittedText);

const replaceText = 'texto'.replace('texto', 'otxet');
console.log('\nSubstituindo texto pelo outro: ', replaceText);

//retorna a fatia de um valor
const lastChar = 'texto'.slice(-1); //ultima letra de uma string
console.log('\nUltima letra de uma string ', lastChar);
