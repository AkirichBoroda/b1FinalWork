using System;
using System.Reflection.Metadata.Ecma335;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Вводим исходный массив строк с клавиатуры или задаем его программно
//         Console.WriteLine("Введите элементы массива через пробел:");
//         string input = Console.ReadLine();
//         string[] initialArray = input.Split(' ');

//         // Считаем количество строк, длина которых меньше или равна 3 символам
//         int count = 0;
//         for (int i = 0; i < initialArray.Length; i++)
//         {
//             if (initialArray[i].Length <= 3)
//             {
//                 count++;
//             }
//         }

//         // Создаем новый массив нужного размера
//         string[] resultArray = new string[count];

//         // Заполняем новый массив
//         int index = 0;
//         for (int i = 0; i < initialArray.Length; i++)
//         {
//             if (initialArray[i].Length <= 3)
//             {
//                 resultArray[index] = initialArray[i];
//                 index++;
//             }
//         }

//         // Вывод массива в строку через запятую
//         Console.WriteLine("Результат: ");
//         Console.WriteLine(string.Join(", ", resultArray));
//     }
// }

class Program
{
    static void Main()
    {
        string[] tmp = new string[1] {"0"};
        string[] inputArray = inputArr();
        // int localtmp = Convert.ToInt16(passingArray(inputArr(),false, tmp));
        // Console.WriteLine(string.Join(", ",passingArray(inputArr(),false, tmp)));
        string[] resultArray = new string[Convert.ToInt16(passingArray(inputArray,false, tmp)[0])];
        resultArray = passingArray(inputArray,true, resultArray);
        Console.WriteLine(string.Join(", ", resultArray));

    }
    static string[] inputArr()
    {
        // input array as string
        Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        return inputArray;
    }
    static string[] passingArray(string[] arr, bool flag, string[] resultArray)
    {
        int ctr = 0;
        string[] stringCtr = new string[1];
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                if (flag)
                {
                    resultArray[ctr] = arr[i];
                    ctr++;
                }
                else
                {
                    ctr++;
                }
                
            }
        }
        
        if (flag) return resultArray;
        stringCtr[0] = Convert.ToString(ctr);
        return stringCtr;
        
        
    }
    
}