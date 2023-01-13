let array = [1,10,10,11,20];
let ind = array.indexOf(20);
console.log(ind);
let hola=Math.max.apply(null,array);
console.log(hola);
let numeros = [3,1,2,15,4];
let hol= numeros.sort(function(a,b)
{
    return a-b
});
console.log(hol);