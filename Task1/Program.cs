Console.Clear();
Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int  maxNumber = numberA;
if (numberB > numberA) {
    maxNumber = numberB;
}
Console.WriteLine($"a= {numberA}; b = {numberB} -> max = {maxNumber}");
// Console.Write("max = ");
// Console.WriteLine(maxNumber);
// Console.WriteLine("max = {0}", maxNumber);
