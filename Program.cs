
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна три символа.


int GetNumber(string message)
{
    int result=0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введено не число или число меньшее или равно нулю. Попробуйте еще раз");
    }
    return result;
}

string [] InitArray(int dimension)
{
    string [] result = new string[dimension];

    for (int i = 0; i < dimension; i++)
    {
        result[i] = Console.ReadLine();
    }

    return result;
}

void PrintArray(string[] array)
{
    Console.Write('[');
    Console.Write(string.Join(", ", array));
    Console.Write("]\n");
}

string[] LessThreeCharArray(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            counter ++;
    }
    string[] lessTheeCharArray = new string[counter];
    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lessTheeCharArray[counter] = array[i];
            counter ++;
        }
    }
    return lessTheeCharArray;
}

int dimension = GetNumber ("Введите размер массива: ");
Console.WriteLine("Введите элементы массива: ");
string [] startArr = InitArray(dimension);
Console.Write("Ваш массив:");
PrintArray(startArr);
string [] arr = LessThreeCharArray(startArr);
Console.Write("Массив из строк, длинна которых меньше или равна 3: ");
PrintArray(arr);
