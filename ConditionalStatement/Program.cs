
// Basic Numeric Comparison Example
// 01. Check if a number is positive, negative, or zero

Console.Write("Enter A Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0)
{
    Console.WriteLine($"The {num1} is a positive number.");
}
else if (num1<0)
{
    Console.WriteLine($" The {num1} is a negative number.");
}
else
{
    Console.WriteLine($"This input number is {num1}");
}