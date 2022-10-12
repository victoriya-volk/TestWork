string [] exampleFirst = {"hello", "2", "world", ":-)"};
string [] exampleSecond = {"1234", "1567", "-2", "computer scince"};
string [] exampleThird = {"Russia", "Denmark", "Kazan"};
// Метод предлагающий пользователю выбрать 
// запуск демо, ввод своего массива или выход из программы
void ChoiseFunctionProgramm ()
{
    Console.WriteLine("This program selects elements that are less then or equal to 3 characters long in the array"
    +"if you want watching demo, press key 'd', else if you want create your array, press key 'm', "
    +"if you want break this programm, please press key 'q'");
    string userChoise = Console.ReadLine();
    if (userChoise == "d")
    {
        Console.WriteLine("First example:");
        PrintArr(exampleFirst);
        string [] resultFirst = ChoiceELemsInArr(exampleFirst);
        PrintArr(resultFirst);
        Console.WriteLine("Second example:");
        PrintArr(exampleSecond);
        string [] resultSecond = ChoiceELemsInArr(exampleSecond);
        PrintArr(resultSecond);
        Console.WriteLine("Third example:");
        PrintArr(exampleThird);
        string [] resultThird = ChoiceELemsInArr(exampleThird);
        PrintArr(resultThird);
        ChoiseFunctionProgramm();
    }
    else if (userChoise == "m")
    {
        string [] userArray = CreateUserArray();
        Console.WriteLine("Your array:");
        PrintArr(userArray);
        Console.WriteLine("Result:");
        PrintArr(ChoiceELemsInArr(userArray));
        ChoiseFunctionProgramm();
    }
    else if (userChoise == "q")
    {
         Console.Clear();
    }
    else 
    {
        Console.WriteLine("That command does not exist");
    }
   
}

// Метод для создания массива пользователем
// Запрашивает количество элементов и каждый элемент по очереди
string [] CreateUserArray ()
{
    Console.WriteLine("Please, enter your array length:");
    int userArrLength = Convert.ToInt32(Console.ReadLine());
    string [] userArr = new string [userArrLength];
    for (int i = 0; i < userArr.Length; i += 1)
    {
        Console.WriteLine($"Enter element number {i + 1}");
        string newElem = Console.ReadLine();
        userArr[i] = newElem;
    }
    return userArr;
}

// Метод для вывода одномерного массива в консоль
void PrintArr (string [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i += 1)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
    }
    Console.Write("]");
    Console.WriteLine();
}

// Метод для проверки наличия эементов удовлетворяющих условию 
// возвращает их количество
int ChackingLengthForNewArr (string [] userArr)
{
    int count = 0;
    for(int i = 0; i < userArr.Length; i += 1)
    {
        
        if (userArr[i].Length <= 3) count +=1;
    }
    return count;
}

// Метод создает новый массив и переносит подходящие элементы
string [] ChoiceELemsInArr (string [] oldArr)
{
    string [] newArr = new string [ChackingLengthForNewArr(oldArr)];
    if (newArr.Length > 0)
    {
        int newStart = 0;
        int j = 0;
        while (j < newArr.Length)
        {
            for (int i = newStart; i < oldArr.Length; i += 1)
            {
                if (oldArr[i].Length <= 3)
                {
                    newArr[j] = oldArr[i];
                    newStart = i;
                    j += 1;
                }
            }
        }
        return newArr;
    }
    else 
    {
        Console.WriteLine("Their are no coincidences in this array");
        return newArr;
    }
}

ChoiseFunctionProgramm();
