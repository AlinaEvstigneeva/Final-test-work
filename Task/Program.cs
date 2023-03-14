/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string [] InitArray ()
{
    Console.Write("Введите количество элементов массива:\t");
    int count = int.Parse(Console.ReadLine());
    
    string[] enteredArray = new string[count];
    for (int i = 0; i < enteredArray.Length; i++)
    {
        Console.Write($"Введите элемент массива по индексом {i}:\t ");
        enteredArray[i] = Console.ReadLine();
    }
    return enteredArray;
}

void PrintArray(string[] enteredArray)
{
    for (int i = 0; i < enteredArray.Length; i++)
    {
        Console.Write($"{enteredArray[i]} ");
    }
    Console.WriteLine();
}

string [] NewArray (string [] result)
{
    string[] newArray = new string[result.Length];
    int j = 0;
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i].Length <= 3)
        {
            newArray[j] = result[i];
            j++;
        }
    }
    return newArray;
} 

string [] result = InitArray ();
PrintArray(result);
string [] finalArray = NewArray (result);
PrintArray(finalArray);

