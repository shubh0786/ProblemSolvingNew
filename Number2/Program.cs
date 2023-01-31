//Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. 

Console.WriteLine("Please Enter your Number");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Write the width");
int wid = int.Parse(Console.ReadLine());

for (int i = 1; i <= wid; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(num + " "  , " \n ");
    }
    Console.WriteLine();
   
}

