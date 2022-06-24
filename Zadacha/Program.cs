// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

class HomeWork
{

    static void Main(string[] args)
    {
        string[] arr1 = new string[4] { "64", "2", "Hello", "Kazan"};
        string[] arr2 = new string[arr1.Length];
         void ArrayWithIF(string[] arr1, string[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].Length <= 3)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
        }
