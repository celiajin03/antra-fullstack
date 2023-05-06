// JavaScript Exercise
// 1. Sum all salaries of our team and store in the variable sum.

let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}
let sum = 0;
for (let person in salaries) {
    sum += salaries[person];
}
console.log('Total Salary is ' + sum + '.');




// 2. Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2. It does not need to return anything and should modify the object in-place.

function multiplyNumeric(menu) {
    for (let key in menu) {
        if (typeof menu[key] === 'number') {
            menu[key] *= 2;
        }
    }
    console.log(menu);
}

let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};
multiplyNumeric(menu);




// 3. Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure '@' must come before '.' and there must be some characters between '@' and '.'. The function must be case-insensitive.

function checkEmailId(str) {
    if (str.match(/\S?@\S+\.\S?/)) {
        console.log('true');
        return true;
    } else {
        console.log('false');
        return false;
    }
}

checkEmailId('s@ah.');




// 4. Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength, replaces the end of str with the ellipsis character "..." to make its length equal to maxlength.
/*
    truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
    truncate("Hi everyone!", 20) = "Hi everyone!"
*/

function truncate(str, maxlength) {
    if (str.length > maxlength) {
        str = str.substring(0, maxlength - 1);
        str += '...';
    }
    console.log(str);
    return str;
}

truncate("What I'd like to tell on this topic is:", 20);
truncate("Hi everyone!", 20);




// 5. Let’s try 5 array operations:
// Create an array styles with items “James” and “Brennie”.
// Append “Robert” to the end.
// Replace the value in the middle by “Calvin”. 
// Remove the first value of the array and show it.
// Prepend Rose and Regal to the array.

let arr = ['James', 'Brennie'];
console.log(arr);

arr.push('Robert');
console.log(arr);

arr[Math.floor(arr.length / 2)] = 'Calvin';
console.log(arr);

let first_val = arr.shift();
console.log(first_val);
console.log(arr);

arr.unshift('Rose', 'Regal');
console.log(arr);
