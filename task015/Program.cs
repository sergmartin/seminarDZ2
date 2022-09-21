// Задача №15

int m = 0;
while (m <= 0 || m >= 8)
{
    Console.Write("Введите цифру дня недели: ");
    m = Convert.ToInt16(Console.ReadLine());
}
if (m == 6 || m == 7) Console.Write("Выходной день!");
else Console.Write("Рабочий день!");