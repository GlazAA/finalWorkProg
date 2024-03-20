using System;

class Program
{
    static void Main()
    {
    
        string[] array1 = new string[100];
        string[] array2 = new string[100];
        int counter = 0;

        Console.WriteLine("Enter the words and numbers. To complete, enter 0:"); // Введите слова и цифры. Для завершения введите 0
        string input;
        do
        {
            input = Console.ReadLine();
            if (input != "0")
            {
                array1[counter] = input;
                counter++;
            }
            
        } while (input != "0");


        int resultCounter = 0;
        for (int i = 0; i < counter; i++)
        {
            if (array1[i].Length < 4)
            {
                array2[resultCounter] = array1[i];
                resultCounter++;
            }
        }

           if (resultCounter == 0)
           {
               Console.WriteLine("All the words or numbers you entered are longer than 3 characters. Enter in short"); //Все слова или цифры, которые вы ввели, длиннее 3-х символов. Введите короче
           }
                    else
                    {
                        Array.Resize(ref array2, resultCounter);

                        Console.WriteLine("Result: \n"); //Результат
                        
                                    for (int i = 0; i < resultCounter; i++)
                                    {
                                        Console.WriteLine(array2[i]);
                                    }
                     }

        Array.Clear(array1, 0, array1.Length);
        Array.Clear(array2, 0, array2.Length);
    }
}