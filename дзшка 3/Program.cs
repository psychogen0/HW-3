using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть номер дня тижня:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедiлок");
}
else if (day == 2)
{
    Console.WriteLine("Вiвторок");
}
else if (day == 3)
{
    Console.WriteLine("Середа");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("П'ятниця");
}
else if (day == 6)
{
    Console.WriteLine("Субота");
}
else if (day == 7)
{ 
    Console.WriteLine("Недiля");
}
else
{ 
    Console.WriteLine("Помилка введення!");
}