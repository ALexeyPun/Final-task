string UserEnter(string message)
{
    Console.Write(message);

    return Console.ReadLine();
}

void FillArray(string[] array)
{
    string meaning = string.Empty;
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        meaning = UserEnter($"Ведите значение для {i} индекса: ");

        if (meaning != string.Empty)
        {
            array[i] = meaning;
            counter++;
        }
        else
        {
            Console.WriteLine("Хотите завершить ввод? ");
            System.Console.WriteLine();
            meaning = UserEnter("\t Введите Y для подтверждения: ");

            if (meaning.ToLower() == "y") break;
            else i--;

        }
    }

    Array.Resize(ref array, counter);
}

string[] RewriteArray(string[] array, int size)
{
    string[] resaltArray = new string[array.Length];
    string str = string.Empty;
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        str = array[i];

        if (str != null && str.Length == size)
        {
            resaltArray[counter] = array[i];
            counter++;
        }
    }

    Array.Resize(ref resaltArray, counter);
    return resaltArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int GetNumber(string message)
{
    int userNumber = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out userNumber)) return userNumber;
        Console.WriteLine("Попробуйте ещё раз!");
    }
}




System.Console.WriteLine("Итоговая работа Паньшина Алексея.");
System.Console.WriteLine();
System.Console.WriteLine("Написать программу, которая из имеющегося массива сторк \nсформирует массив строк равным 3-ём символам.");
System.Console.WriteLine();

System.Console.WriteLine("Заполните массив: ");

string[] array = new string[100];
FillArray(array);
System.Console.WriteLine();

int countSimbols = GetNumber("Введите нужное количество элементов строк: ");
string[] sortArray = RewriteArray(array, countSimbols);

PrintArray(array);
System.Console.WriteLine();
PrintArray(sortArray);