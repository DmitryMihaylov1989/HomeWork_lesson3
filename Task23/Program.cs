// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.




// напишите программу которая  принимает на вход  число N
// и выдает таблицу кубов чисел от 1 до (N)
// 5->1,4,9,16,
//   
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    Console.WriteLine($"куб {count} = {Math.Pow(count, 3) }");
    count++;
}
