int[] TotalArray(int col)
{
    int[] array = new int[col];
    int i = 0;
    while (i < array.Length)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 10);
        Console.WriteLine(Convert.ToString(array[i]) + ", ");
        i++;
    }
    return array;
}



Console.WriteLine("Введите длинну массива: ");
int total = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[] mass = TotalArray(total);
int m = 0;
for(int i = 0; i < mass.Length; i++){
    if(i % 2 == 1){
        m = m + mass[i];
    } 
}

Console.Write("Ответ: " + Convert.ToString(m));
