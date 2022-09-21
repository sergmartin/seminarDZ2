// Задача № 10

int m = 0;
while (m < 100 || m > 1000)
{
    Console.Write("Введите трехзначное число: ");
    m = Convert.ToInt16(Console.ReadLine());
}
Console.WriteLine("Число. которое ввели Вы: " + m);

//int m = new Random().Next(100, 1000);
//Console.WriteLine(m);
string n = Convert.ToString(m);
Console.WriteLine("Второй символ Вашего числа: " + n[1]);