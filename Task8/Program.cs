/* Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N. */
Console.Clear();
Console.Write("Ведите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
int i = 1;
bool isFirst = true;
while (i <= number) {
    if (i % 2 == 0) {
        string prefix = isFirst ? "" : ", ";
        Console.Write($"{prefix}{i}");
        if (isFirst) {
            isFirst = false;
        }
    }
    i++;
}