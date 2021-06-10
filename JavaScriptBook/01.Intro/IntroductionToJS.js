
/*
let admin;
let name = 'John';
admin = name
console.log(admin);
*/
/*
let planetEarth;
let currentUserName;
*/
/*let str = "Hello";
let str2 = 'Single quotes are ok too';
let phrase = `Can embed another ${str}`;

console.log(str);
console.log(str2);
console.log(phrase);
*/
/*
let age = 15;

if(age >= 14 && age <= 90)
{
    alert('You are ready to Drink!');
}
else
{
    alert ('You are not ready to Drink!');
}
*/

// let user = prompt('Nickname:','');


// if (!user || user != 'Admin')  {
//     alert("Wrong Username or Canceled!");
// }
// else
// {
// let password = prompt('Password:','');

// (password == 'TheMaster') ? alert('Welcome!') :
// (password == '') ? alert('Canceled') :
// alert('Wrong Password!'); 
// }

// Function to listen for pressed Key!!!!! 
// <script>
// function myPress(event){

// 	console.log(event);
// 	alert(event);
// }

// document.onkeypress = myPress;


// </script>

// <button onkeypress={myPress} onclick={myPress}>Borjo</button>

// </body>
// </html>

// let i = 0;

// do {
//     alert(i);
//     i++;
// }
// while(i < 3);

// let sum = 0;

// while (true) {
//     let value = +prompt('Wnter a number', '');

//     if(!value) {
//         break;
//     }

//     sum += value;
// }

// alert('Sum: ' + sum);

// for(let i = 0; i <= 10; i++) {
//     if(i % 2 == 0) {
//         alert(i);
//     }
// }

// let i = 0;

// while ( i < 3) {
//     alert (`number ${i}!`);
//     i++;
// }



// My way 
// while (true) {
//     let number = +prompt('Enter a number greated than 100:','');

//     if (number < 100) {
//         alert(`Your number ${number} is lower than 100! Please try again!`);      
//     }
//     else {
//         break;
//     }

// }

//Book way

// let num;

// do {
//     num = +prompt("Enter a number greater than 100:", 0);
// }
// while(num <= 100 && num);


//Prime Numbers!
// let inputNumber = +prompt("Enter a number which will be the closing interval:", "");

// nextPrime:
// for(let i = 3;i <= inputNumber; i++) {
//     for( let j = 2; j < i; j++) {
//         if(i % j == 0) {
//             continue nextPrime;
//         }      
//     }

//     alert (i);
// }


// let userName = prompt('Enter your Name:','');
// console.log(userName);
// const regex = /\d/;

// while (userName === '' || regex.test(userName) || userName == null) {
//     alert('You entered an invalid Name! Try again!');
//     userName = prompt('Enter your Name:','');
// }

// let course = prompt('Enter your Course: (C#-Advanced, Java-Basics, HTML&CSS)','');
// const suggestions = ['C#-Advanced', 'Java-Basics', 'HTML&CSS']

// while (course === '' || !suggestions.includes(course)) {
//     alert('You entered invalid course! Please try again and watch the suggestions closely!');
//     course = prompt('Enter your Course: (C#-Advanced, Java-Basics, HTML&CSS)','');
// }

// ---------------
// Functions

// function sayHi() {
//     alert('Hello');
// }

// let sayHi = function() {
//     alert('Hello');
// }

// let func = sayHi;

// func();
// sayHi();


// function ask(question, yes, no) {
//     if(confirm(question)) {
//         yes()
//     }
//     else no();
// }

// function showOk() {
//     alert ('You agreed!');
// }

// function showCancel() {
//     alert('You canceled the execution.');
// }

// ask('Do You Agree?', showOk, showCancel);



// function checkAge(age) {
//     (age > 18) ? true : confirm('Did parents allow you?');
// }

// alert(checkAge(14));

// function checkAge(age) {
//     return (age > 18) || confirm('Did parents allow you?');
// }

// function min(a, b) {
//     (a < b) ? alert(a) : alert(b);
// }

// min(2, 5);
// min(3, -1);
// min(1,1);

// function pow(x, n) {
//     return alert(Math.pow(x, n));
// }

// pow(3, 2);
// pow(3, 3);
// pow(1, 100);

// const ask = (question, yes, no) => confirm(question) ? yes() : no();




//---------------------------------------------------




// let input = [
//     'Pesho C#-Advanced 100 3',
//     'Gosho Java-Basics 157 3',
//     'Tosho HTML&CSS 317 12',
//     'Minka C#-Advanced 57 15',
//     'Stanka C#-Advanced 157 15',
//     'Kircho C#-Advanced 300 0',
//     'Niki C#-Advanced 400 10',
//     'C#-Advanced'
// ];

// examRes(input);


// function examRes(input) {
//     let student;
//     let course;
//     let examPoints;
//     let courseBonuses;
//     let coursePoints;
//     let grade;
//     let sumAveragePoints = 0;
//     let counter = 0;
//     let lastLineString = input[input.length-1].trim();

//     for (let i = 0; i < input.length - 2; i++) {
//         let splitString = input[i].split(' ');

//         student = splitString[0]; // Pesho
//         course = splitString[1].trim(); // C#-Advanced
//         examPoints = Number(splitString[2]);//100
//         courseBonuses = Number(splitString[3]);//3
//         coursePoints = (0.2 * examPoints) + courseBonuses;//23
//         grade = ((coursePoints / 80) * 4) + 2;

//         if(grade > 6) {
//             grade = 6.00;
//         }

//         if (course === lastLineString) {
//             sumAveragePoints += examPoints;
//             counter++;
//         }

//         if (examPoints < 100) {
//             console.log(`${student} failed at "${course}"`);
//             continue;
//         }

//         console.log(`${student}: Exam - "${course}"; Points - ${Math.floor(coursePoints * 100) / 100}; Grade - ${grade.toFixed(2)}`);
//     }

//     console.log(`"${lastLineString}" average points -> ${Math.floor((sumAveragePoints / counter) * 100) / 100}`);
// }

// function FilterMatrix(input) {
//     let sequenceLength = Number(input[input.length - 1]);
//     let counter = 1;
//     let previousDigit;
//     let indexesToDelete = [];
//     let oneLiner= [];



//     for (let i = 0; i < input.length - 1; i++) {
//         let currentLine = input[i];
//         let numbersArray = currentLine.split(' ');

//         oneLiner.push(...numbersArray);

//         for (let j = 0; j < numbersArray.length; j++) {
//            indexesToDelete.push({start: { row: i, col: j}}); 
//            const currentDigit = numbersArray[j]


//             if (currentDigit === previousDigit) {
//                 counter++;
//             }

//             if (counter === sequenceLength) {
//                 numbersArray.splice(j, sequenceLength);
//                 counter = 1;
//                 j -= sequenceLength;
//             }

//             previousDigit = currentDigit;
//         }
//     }

//     console.log(oneLiner);
// }



// let input = [
//     '3 3 3 2 5 9 9 9 9 1 2',
//     '1 1 1 1 1 2 5 8 1 1 7',
//     '7 7 1 2 3 5 7 4 4 1 2',
//     '2'
// ];

// FilterMatrix(input);


// function FilterMatrix(input) {
//     let sequenceLength = Number(input[input.length]);
//     let firstDigitOfNewLine = secondLineArray[0];
//     let currentDigit;
//     let counter = 1;
//     let lastDigit = firstLineArray[firstLineArray.length];

//     for (let i = 0; i < firstLineArray.length - 1; i++) {
//         currentDigit = firstLineArray[i];

//         if (currentDigit === firstLineArray[i + 1]) {
//             counter++;
//         }

//         if (counter === sequenceLength) {
//             firstLineArray.splice(i, sequenceLength);
//             counter = 1;
//             i--;
//         }        
//     }

//     if(lastDigit === firstLineArray[firstLineArray.length - 2] && lastDigit === firstDigitOfNewLine) {

//         for (let i = 0; i < secondLineArray.length - 1; i++) {
//             currentDigit = secondLineArray[i];

//             if (currentDigit === secondLineArray[i + 1]) {
//                 counter++;
//             }

//             if (counter === sequenceLength) {
//                 secondLineArray.splice(i, sequenceLength);
//                 counter = 1;
//                 i--;
//             }        
//         }
//     }



// }





// function FilterMatrix(input) {
//     let currentDigit;
//     let previousDigit;
//     let counter = 1;
//     let sequenceLength = input[input.length -  1];
//     let arrayOfAllNumbers = [];
//     let currentObject = [,]
//     let arrayOfIndexesToDelete = [];

//     for(let i = 0; i < input.length - 2; i++) { //row
//         let currentLine = input[i];
//         let numbersArray = +currentLine.split(' ');

//         arrayOfAllNumbers.push(...numbersArray);
//     }

//     for(let i = 0; i < arrayOfAllNumbers.length - 1; i++) {
//         currentDigit = arrayOfAllNumbers[i];

//         if(currentDigit === arrayOfAllNumbers[i + 1]) {
//             counter++;
//         }

//         if(counter === sequenceLength) {

//         }
//     }


// }


// let input = [
//     '3 3 3 2 5 9 9 9 9 1 2',
//     '1 1 1 1 1 2 5 8 1 1 7',
//     '7 7 1 2 3 5 7 4 4 1 2',
//     '2'
// ];

// FilterMatrix(input);


// function FilterMatrix(input) {
//     let sequenceLength = input[input.length - 1];
//     let oneLinerArray = [];
//     let counter = 1;
//     let output = '';

//     for (let i = 0; i < input.length - 1; i++) {
//         let lastDigit = input[i].length - 1;

//         input[i] += ' -10000';

//         let numbersArray = input[i].split(' ');

//         oneLinerArray.push(...numbersArray);
//     }

//     for (let index = 0; index < oneLinerArray.length - 1; index++) {
//         let currentNumber = oneLinerArray[index];

//         if (oneLinerArray[index + 1] !== '-10000') {
//             if (currentNumber === oneLinerArray[index + 1]) {
//                 counter++;

//                 if (counter === sequenceLength) {
//                     oneLinerArray.splice(index - (counter - 2), sequenceLength);
//                     counter = 1;
//                 }
//             }
//         }
//         else if (currentNumber === oneLinerArray[index + 2]) {
//             counter++;

//             if (counter === sequenceLength) {
//                 oneLinerArray.splice(index - (counter - 2), sequenceLength + 1, '-10000');
//                 counter = 1;
//             }
//         }
//     }

//     for (let i = 0; i < oneLinerArray.length; i++) {
//         output += `${oneLinerArray[i]} `;

//         if (oneLinerArray[i + 1] === '-10000') {
//             console.log(output);
//             output = '';
//             i++;
//         }
//     }
// }




const input = `#RoYaL: I'm not sure what you mean, 
but I am confident that I've written everything correctly.
Ask #iordan_93 and #pesho if you don't believe me 
<code>
#trying to print stuff
print("yoo")
</code>
pesho gosho`;

SoftUniForum(input);

function SoftUniForum(input) {
    const firstChar = input[0];
    let getAllTextTillSpecificWord = input.match(/(#\w*[\s*\S*]*)<code>/g);
    // let getAllTextAfterSpecificWord = input.match(/<code>\n(\#\w*[\s*\S*]*)<\/code>/g)
    const regEx = /#(?<wordsWithNumberSign>[\w+\-*]+)/g;
    let bannedNames = input.match(/<\/code>\n(?<bannedNames>\w*[\s*\S*]*)/g);
    let bannedNamesWithoutCode = bannedNames[0].replace(/<\/code>\n/, '');
    let allWordsStartingWithNumberSignBeforeCode = getAllTextTillSpecificWord[0].match(regEx); //Array = ['#RoYaL', '#iordan_93', '#pesho']
    //let allWordsStartingWithNumberSignAfterCode = getAllTextAfterSpecificWord[0].match(regEx); //Array = ['#trying']

    while(regEx.test(getAllTextTillSpecificWord)) {
        //while finding matches get index of it and replace them with the strings in allWordsStartingWithNumberSignBeforeCode
        //remove last line and concat() the 2 strings
    }

    for (let i = 0; i < allWordsStartingWithNumberSignBeforeCode.length; i++) {
        let currentString = allWordsStartingWithNumberSignBeforeCode[i]

        if (CheckLastChar(currentString)) {
            allWordsStartingWithNumberSignBeforeCode.splice(i, 1, `Invalid name: ${currentString}`);
        }

        if (allWordsStartingWithNumberSignBeforeCode.includes(currentString)) {
            nameWithoutNumberSign = currentString.slice(1);
            allWordsStartingWithNumberSignBeforeCode.splice(i, 1, `<a href="/users/profile/show/${nameWithoutNumberSign}">${nameWithoutNumberSign}</a>`);
        }
    }

    let bannedNamesArray = bannedNamesWithoutCode.split(' ');

    for (let i = 0; i < bannedNamesArray.length; i++) {
        let bannedNameToSearch = `<a href="/users/profile/show/${bannedNamesArray[i]}">${bannedNamesArray[i]}</a>`;

        for (let j = 0; j < allWordsStartingWithNumberSignBeforeCode.length; j++) {
            let currentStringToEvaluate = allWordsStartingWithNumberSignBeforeCode[j];

            if (currentStringToEvaluate === bannedNameToSearch) {
                let indexOfBannedName = allWordsStartingWithNumberSignBeforeCode.indexOf(bannedNameToSearch);

                allWordsStartingWithNumberSignBeforeCode.splice(indexOfBannedName, 1, '******')//ReplaceAlphanumericalSymbolsWithSnowflake(bannedNameToSearch));
            }
        }
    }

    function CheckLastChar(someString) {
        let lastChar = someString[someString.length - 1];

        if (someString.length < 3) return true;

        if (/[a-zA-Z0-9]/.test(lastChar)) return false;

        return true;
    }

    // function ReplaceAlphanumericalSymbolsWithSnowflake(stringToReplace) {
    //     for (let i = 0; i < stringToReplace.length; i++) {
    //         console.log(stringToReplace[i]);
    //         stringToReplace.splice(i, 1, '*');
    //         console.log(stringToReplace[i]);
    //     }

    //     return stringToReplace;
    // }
}
