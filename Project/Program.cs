// Написать программу, которая из имеющегося массива строк сформирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// с клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// ["Russia", "Denmark", "Kazan"] => []


Console.WriteLine("Programm to create the new array from the existed array with elements more or equal than 3 symbols");

Console.Write("Input the elements number:\t");
int size;

while (!int.TryParse(Console.ReadLine()!, out size) || size <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the elements number:\t");
}

Console.Write("Input the max symbols number:\t");
int maxSymbolLength;

while (!int.TryParse(Console.ReadLine()!, out maxSymbolLength) || maxSymbolLength <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the max symbols number:\t");
}

string[] array = GetArray(size);

Console.Write("\nThe root array is: ");
PrintArray(array);

int array2Length = GetArray2Length(array);

string[] array2 = GetArray2(array);

Console.Write("\nThe new array is: ");
PrintArray(array2);

string[] GetArray(int size)
{
    Console.WriteLine("Input the elements (after every input press 'Enter'):");
    string[] array = new string[size];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) 
            Console.Write($"\"{array[i]}\", ");
        else
            Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

int GetArray2Length(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= maxSymbolLength) count++;
    }

    return count;
}

string[] GetArray2(string[] array)
{
    string[] array2 = new string[array2Length];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= maxSymbolLength)
        {
            array2[index] = array[i];
            index++;
        }
    }
    return array2;
}
