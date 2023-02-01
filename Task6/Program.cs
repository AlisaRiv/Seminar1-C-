/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
 (делится ли оно на два без остатка). */
Console.Clear();
Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string evenName = numberA % 2 == 0 ? "да" : "нет";
Console.WriteLine($"{numberA} -> {evenName}");
