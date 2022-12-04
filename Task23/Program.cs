// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
int number = ReadInt("Enter a number: ");
Console.WriteLine($"Values of cube numbers from 1 to {number}: ");
for (int i=1; i<=number; i++)
{
    Console.Write(Math.Pow(i,3)+" ");
}


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

