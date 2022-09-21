// Задача №13

int m = 0;
while (m <= 0)
{
    Console.Write("Введите положительное число: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Число. которое ввели Вы: " + m);

string n = Convert.ToString(m);
if (n.Length < 3) Console.Write("нет третьей цифры");
else Console.Write("Третья цифра Вашего числа: " + n[2]);
