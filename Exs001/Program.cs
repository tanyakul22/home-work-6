Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
int chek = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        chek++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше 0: {chek}");
