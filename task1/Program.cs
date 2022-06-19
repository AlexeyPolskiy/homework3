// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = prompt("Введите пятизначное число N => ");
if (numberInt < -99999 || numberInt > 99999)
{
    System.Console.WriteLine("Вы ввели не коректное число");
    Environment.Exit(0);
}
