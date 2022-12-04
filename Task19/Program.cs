// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

while(true)
{
    int number = ReadInt("Enter a five-digit number to find out if it's a polyndrom: ");
    if (number<0 || number>99999 || number<999)
    {
        Console.WriteLine("You entered an incorrect number. Please, enter a five-digit natural number.");
        continue;
    }
    else
    {
        for(int i=1, count=5; i<3; i++, count--)
        {
            if (CompareDigit(i) != CompareDigit(count))
            {
                Console.WriteLine($"Tne number {number} is not polyndrom.");
                break;
            }
            else
            {
                Console.WriteLine($"Tne number {number} is polyndrom.");
            }
        }
        
    }


double CompareDigit(int x)
{
    double result = number%Math.Pow(10,x);
    return result;
}
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}