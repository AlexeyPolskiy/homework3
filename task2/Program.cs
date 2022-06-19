// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int degree(int Num)
{
    return Num * Num;
}

int numberIntAX = prompt("Введите координату X числа A -> ");
int numberIntAY = prompt("Введите координату Y числа A -> ");
int numberIntAZ = prompt("Введите координату Z числа A -> ");
int numberIntBX = prompt("Введите координату Х числа B -> ");
int numberIntBY = prompt("Введите координату Y числа B -> ");
int numberIntBZ = prompt("Введите координату Z числа B -> ");

double answer = Math.Sqrt(degree(numberIntAX - numberIntBX) + degree(numberIntAY - numberIntBY) + degree(numberIntAZ - numberIntBZ));

System.Console.WriteLine(answer);