// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

void RandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(0,100)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

int size = Convert.ToInt32(5);
double[] numbers = new double[size];
RandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;
double result = 0;

for (int A = 0; A < numbers.Length; A++)
{
    if (numbers[A] > max)
        {
            max = numbers[A];
        }
    if (numbers[A] < min)
        {
            min = numbers[A];
        }
}
result = max - min;
Console.WriteLine ($"Максимальное значение = {max}");
Console.WriteLine ($"Минимальное значение = {min}");
Console.WriteLine ($"Разница между максимальным и минимальным значением = {result}");