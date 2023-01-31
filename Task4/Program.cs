Console.Clear();
Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int  maxNumber = numberA;
if (numberB > maxNumber) {
    maxNumber = numberB;
}
if (numberC > maxNumber) {
    maxNumber = numberC;
}
Console.WriteLine($"{numberA},{numberB},{numberC} -> {maxNumber}");
