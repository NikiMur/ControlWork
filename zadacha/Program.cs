Console.WriteLine("введи симовлы символы");
string[] array = new string[5]; 
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine();
    array[i] = Console.ReadLine(); 
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine();
    Console.Write(array[i] + "\t");

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Строки с колличеством символов не больше 3");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i]+ "\t");
    }
}
Console.WriteLine();

