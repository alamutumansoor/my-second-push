Console.Write("how many numbers: ");
int count = int.Parse(Console.ReadLine()!);

Console.Write("Enter number 1: ");
int number = int.Parse(Console.ReadLine()!);

int smallest = number; 
int largest = number;
while (i <= count)
{
    Console.WriteLine($"Enter number {i}: ");
    number = int.Parse(Console.ReadLine()!);
    i++;
    if(number < smallest) smallest = number;
}
   Console.WriteLine($"Smallest: {smallest}");
   Console.WriteLine($"Largest: {largest}");