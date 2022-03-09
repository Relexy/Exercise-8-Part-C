/* Exercise 8 Part C */

//User Input 
Console.WriteLine("Enter 10 Whole Numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
while (num1 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}

int num2 = Convert.ToInt32(Console.ReadLine());
while (num2 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}

int num3 = Convert.ToInt32(Console.ReadLine());
while (num3 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
}

int num4 = Convert.ToInt32(Console.ReadLine());
while (num4 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num4 = Convert.ToInt32(Console.ReadLine());
}

int num5 = Convert.ToInt32(Console.ReadLine());
while (num5 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num5 = Convert.ToInt32(Console.ReadLine());
}

int num6 = Convert.ToInt32(Console.ReadLine());
while (num6 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num6 = Convert.ToInt32(Console.ReadLine());
}

int num7 = Convert.ToInt32(Console.ReadLine());
while (num7 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num7 = Convert.ToInt32(Console.ReadLine());
}

int num8 = Convert.ToInt32(Console.ReadLine());
while (num8 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num8 = Convert.ToInt32(Console.ReadLine());
}

int num9 = Convert.ToInt32(Console.ReadLine());
while (num9 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num9 = Convert.ToInt32(Console.ReadLine());
}

int num10 = Convert.ToInt32(Console.ReadLine());
while (num10 < 0)
{
    Console.WriteLine("ERROR. Enter A Whole Number: ");
    num10 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"The Sum Of Your Numbers Is: {num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10}");

// Sorts The Numbers They Enter From Lowest To Highest
int[] numbers = {num1, num2, num3, num4, num5, num6, num7, num8, num9, num10};
Array.Sort(numbers);

// An Array In C#, Number Order Starts From 0 
Console.WriteLine($"Your Lowest Number Entered Was: {numbers[0]} \nYour Highest Number Entered Was: {numbers[9]}");

