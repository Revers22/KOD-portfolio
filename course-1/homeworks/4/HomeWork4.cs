Console.WriteLine("===========================================================");
// Калькулятор оценок
int[] grades = { 5, 5, 4, 3, 3, 4, 2 };
float set = 0;
float result_1 = 0;
int A = 0;
int F = 0;
for (int i = 0; i < grades.Length; i++)
{
    set += grades[i];
    if (grades[i] == 5)
    {
        A += 1;
    }
    if (grades[i] == 2)
    {
        F += 1;
    }
    if (i == (grades.Length - 1))
    {
        result_1 = set / 7;
        Console.WriteLine("средний балл:");
        Console.WriteLine(result_1);
        Console.WriteLine("пятёрок:");
        Console.WriteLine(A);
        Console.WriteLine("двоек:");
        Console.WriteLine(F);
    }
}
Console.WriteLine("===========================================================");
//Переворот массива 
int[] numbers = { 10, 17, 42, 67, 52 };
int[] numbers_rev = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    numbers_rev[i] = numbers[numbers.Length - 1 - i];
}
for (int i = 0; i < numbers_rev.Length; i++)
{
    Console.WriteLine(numbers_rev[i]);
}
Console.WriteLine("===========================================================");
//Вывод четных чисел
for (int i = 0; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.WriteLine("===========================================================");
//Ввод пароля с ограничением по попыткам
int tryes = 1;
int password = 1234;
while (true)
{
    Console.WriteLine("введите пороль:");
    int password_chek = int.Parse(Console.ReadLine());
    if (password_chek == password)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    else if (tryes < 3)
    {
        Console.WriteLine("пороль неверный");
        Console.WriteLine("осталось: " + (3 - tryes) + " попыток");
        tryes++;
        continue;
    }
    else
    {
        Console.WriteLine("Доступ запрещён");
        break;
    }
}