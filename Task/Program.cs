// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "word", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void Array (string [] Array1)
{
    string [] ArrayFinal = new string [Array1.GetLength(0)];
    int count = 0;
    Console.Write("Результат: [");
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        if (Array1[i].Length <= 3)
        {
            ArrayFinal[count] = Array1[i];
            Console.Write(ArrayFinal[count]);
            if (i != ArrayFinal.Length - 1)
                Console.Write(", ");
            count++;
        }        
    }
    Console.Write("]");
}
string[] ArrayOrig = new string[] {"hello", "2", "word", ":-)"};
Array (ArrayOrig);