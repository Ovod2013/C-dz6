// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Vvod(string zapros)
{
    Console.Write(zapros);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int m=Vvod("Введите количество чисел, которое желаете ввести: ");
Console.WriteLine("Вводите целые числа");
int kolPol=0;
for (int i=0; i<m; i++)
{
int a = Vvod($"Введите {i+1} число: ");
//Console.Write(",");
if (a>0) kolPol=kolPol+1;
}
Console.WriteLine($"Количество введённых положительных чисел: {kolPol}");
