Console.Clear();
Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string evenName = numberA % 2 == 0 ? "да" : "нет";
Console.WriteLine($"{numberA} -> {evenName}");
