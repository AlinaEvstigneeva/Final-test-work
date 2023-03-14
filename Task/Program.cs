/* Написать программу, которая из имеющегося массивастрок формирует массив из строк, длина которых меньше либо равна 3 символа. 
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



string [] result = InitArray ();
PrintArray(result);


