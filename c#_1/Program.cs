Console.Write("Enter number one: ");
int num1;
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number two: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine($"Yes!");
}
else
{
    Console.WriteLine($"No!");
}