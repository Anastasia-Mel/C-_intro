﻿Console.WriteLine("Enter number from one to seven: ");
int num;
num = Convert.ToInt32(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine($"Monday");
}
if(num == 2)
{
    Console.WriteLine($"Tuesday");
}
if(num == 3)
{
    Console.WriteLine($"Wednesday");
}
if(num == 4)
{
    Console.WriteLine($"Thursday");
}
if(num == 5)
{
    Console.WriteLine($"Friday");
}
if(num == 6)
{
    Console.WriteLine($"Saturday");
}
if(num == 7)
{
    Console.WriteLine($"Sunday");
}
else
{
    Console.WriteLine($"Wrong number!");
}