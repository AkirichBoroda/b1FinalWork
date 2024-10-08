
class Program
{
    static void Main()
    {
        string[] tmp = new string[1] {"0"};
        string[] inputArray = inputArr();
        string[] resultArray = new string[Convert.ToInt16(passingArray(inputArray,false, tmp)[0])];
        if (resultArray.Length > 0)
        {
            resultArray = passingArray(inputArray,true, resultArray);
            Console.WriteLine(string.Join(", ", resultArray));
        }
        else
        {
            Console.WriteLine("отсутствуют строки подходящие под условие");
        }
        

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