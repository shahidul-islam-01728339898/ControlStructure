﻿
//// Basic Numeric Comparison Example
//// 01. Check if a number is positive, negative, or zero

//using System.Transactions;

//Console.Write("Enter A Number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//if (num1 > 0)
//{
//    Console.WriteLine($"The {num1} is a positive number.");
//}
//else if (num1 < 0)
//{
//    Console.WriteLine($" The {num1} is a negative number.");
//}
//else
//{
//    Console.WriteLine($"This input number is {num1}/ Zeor");
//}


////02.Check the two integers are equal/greater or not

//Console.Write("Enter Your First Number: ");
//double number1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter Second Number: ");
//double number2 = Convert.ToDouble(Console.ReadLine());

//if (number1 == number2)
//{
//    Console.WriteLine($"The First number: {number1} and the Second number :{number2} are equal");
//}
//else if(number1> number2)
//{
//    Console.WriteLine($"The First number: {number1} is greater than the Second number: {number2}");

//}
//else if(number2>number1)
//{
//    Console.WriteLine($"The Second number: {number2} is greater than the First number: {number1}");
//}
//else
//{
//    Console.WriteLine($"The First number: {number1} and the Second number: {number2} is a general number");
//}



////03. Check the number using switch statement
//Console.Write("Enter A Number: ");
//int degit = Convert.ToInt32(Console.ReadLine());

//switch (degit)
//{
//    case 0:
//        Console.WriteLine("Yes, this is Zero Number");
//        break;
//    case 1:
//        Console.WriteLine("Yes, this is One Number");
//        break;
//    case 2:
//        Console.WriteLine("Yes, This is Two");
//        break;
//    case 3:
//        Console.WriteLine("Yes, This is Three");
//        break;
//    case 4:
//        Console.WriteLine("Yes, This is four");
//        break;
//    default:
//        Console.WriteLine("This is not a valid number between 0 to 4)");
//        break;

//}


//04. Check vowel charecter using switch statement with string input


//Console.Write("Enter a Valid letter: ");
//char letter = Convert.ToChar(Console.ReadLine());

//switch (char.ToLower(letter))
//{
//    case 'a':
//    case 'e':
//    case 'i':
//    case 'o':
//    case 'u':
//        Console.WriteLine($"This {letter} is a vowel letter");
//        break;
//    default:
//        if (char.IsLetter(letter))
//        {
//            Console.WriteLine($"This Letter: '{letter}' is a consonant");
//        }
//        else
//        {
//            Console.WriteLine($"This is not a valid character");
//        }
//        break;
//}


//05. Check the day using switch statement

Console.Write("Write the name of a single day: ");
string day= Console.ReadLine();

switch (day)
{
    case "saturday":
        Console.WriteLine();
        break;
    case "sunday":
        Console.WriteLine("This is sunday");
        break;
    case "monday":
        Console.WriteLine("This is monday");
        break;
    case "tuesday":
        Console.WriteLine("This is Tuesday");
        break;

    default:
        Console.WriteLine("This is not a valid Day");
        break;
}

