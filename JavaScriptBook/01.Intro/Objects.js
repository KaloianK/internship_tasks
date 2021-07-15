// let user = {};
// user.name = 'John';
// user.surname = 'Smith';
// user.name = 'Pete';
// delete user.name;
// -----------------------------------
//     let shedule = {};

// function isEmpty(shedule) {
//     for (let key in shedule) {
//         return false;
//     }

//     return true;
// }

// console.log(isEmpty(shedule));

// shedule['8:30'] = 'get up'

// console.log(isEmpty(shedule));
// ------------------------------------------

//     let salaries = {
//         John: 100,
//         Ann: 160,
//         Pete: 130
//     };

// let sum = 0;

// for (let salary in salaries) {
//     sum += salaries[salary];
// }

// console.log(sum);
// ----------------------------------

// let menu = {
//     width: 200,
//     height: 300,
//     title: 'My menu'
// };

// function multiplyNumeric(menu) {
//     for(let key in menu) {
//         if(typeof menu[key] === 'number') {
//             menu[key] *= 2;
//             console.log(menu[key]);
//         }
//     }
// }

// multiplyNumeric(menu);
//------------------------------------------

// let user = {
//     name: 'John',
//     age: 30
// };

// let clone = {};

// for(let key in user) {
//     clone[key] = user[key];
// }

// console.log(user.name);
// console.log(user.age);
// console.log(clone.name);
// console.log(clone.age);

// clone.name = 'Pete';
// clone.age = 25;

// console.log(clone.name);
// console.log(clone.age);


// let user = {
//     name: 'John',
//     age: 30
// };

// let userName = user.name;
// let userAge = user.age;

// let clone = {}

// Object.assign(clone, user);

// console.log(user.name);
// console.log(user.age);
// console.log(clone.name);
// console.log(clone.age);
// console.log(clone == user);

// clone.name = 'Pete';
// clone.age = 25;
// console.log(clone.name);
// console.log(clone.age);

// let user = {
//     name: 'John'
// };

// let admin = user;

// user = null;

// console.log(user);
// console.log(admin.name);
//------------------------------------

// let user = {
//     name: 'John',
//     age: 30
// };

// function sayHi() {
//     console.log(this);
// }

// user.sayHi = sayHi;
// user.sayHi();

// let admin = user;
// user = null;

// admin.sayHi()

// sayHi();

// let calculator = {
//     sum() {
//         return this.a + this.b;
//     },

//     mul() {
//         return this.a * this.b;
//     },

//     read() {
//         this.a = +prompt('a?','');
//         this.b = +prompt('b?','');
//     }
// };

// calculator.read();
// alert(calculator.sum());
// alert(calculator.mul());


// function makeUser() {
//     return {
//         name: 'John',
//         age: 30,
//         ref() {
//             return this;
//         }, 
//         ref2: this
//     };
// }

// let user = makeUser();

// console.log(user.ref);
// console.log(user.ref());
// console.log(user.ref().name);
// console.log(user.ref().age);
// console.log(user.ref2);
// console.log(user.ref2());

// function ucFirst(name) {
//    let newName = name[0].toUpperCase() + name.slice(1);
//     console.log(newName);
// }

// let name = 'john';

// ucFirst(name);

// function checkSpam(str) {
//     str = str.toLowerCase();

//     return str.includes('viagra') || str.includes('xxx');

// }

// console.log(checkSpam('buy ViAgRA now'));
// console.log(checkSpam('free xxxxx'));
// console.log(checkSpam("innocent rabbit"));

// let array = ['Jazz', 'Blues'];

// array.push('Rock-n-Roll');
// console.log(array);

// for(let i = 0; i < array.length; i++) {
//     if(i === (array.length / 2)) {
//         array[i] = 'Classics';
//     }
// }

// console.log(array);

// array.shift();

// console.log(array);

// array.unshift('Rap', 'Reggae');

// console.log(array);

// let values = ['Hare', 'Krishna', 'Hare', 'Krishna',
// 'Krishna', 'Krishna', 'Hare', 'Hare', ':-O'];

// console.log(unique(values));

// function unique(arr) {
//     let set = new Set();

//     for(let value in values) {
//         set.add(values[value]);
//     }

//     return set;
// }



// let map = new Map();

// map.set('name', 'John');

// let keys = map.keys();
// let keys = Array.from(map.keys());

// keys.push('more');

// console.log(keys);


// let map = new Map(Object)

// let arr = ['dog', 'cat', 'borjo'];

// const newarr = arr.map(kop => kop + " is gay");

// for (let kop in arr) {

// }
// console.log(arr, newarr);


// let user = {
//     name: 'John',
//     age: 30
// }

// alert( count(user) );

// function count(obj) {
//     return Object.keys(obj).length;
// }

let user = {
    name: 'John',
    years: 30
};

let {name, years, isAdmin = false} = user;

alert( name );
alert( years );
alert( isAdmin );