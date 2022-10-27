// принимает на вход трёхзначное число
//и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Enter three-digit number: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
int lastNum = num % 10;
Console.WriteLine("The last digit of the number: " + lastNum);