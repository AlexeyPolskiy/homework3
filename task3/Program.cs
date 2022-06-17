// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberInt = prompt("Введите число N -> ");
for (int i = 1; i <= numberInt; i++)
{
    double answer = Math.Pow(i, 3);
    System.Console.Write($"{answer} ");
}
