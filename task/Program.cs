string [] exampleFirst = {"hello", "2", "world", ":-)"};
string [] exampleSecond = {"1234", "1567", "-2", "computer scince"};
string [] exampleThird = {"Russia", "Denmark", "Kazan"};

void ChoiseFunctionProgramm ()
{
    Console.WriteLine("This programm choices elements whith smaller 4 signs length in array"
    +"if you want watching demo, press key 'd', else if you create your array, press key 'm', "
    +"if you want break this programm, please press any one other key");
    string userChoise = Console.ReadLine();
    Console.Write(userChoise);
}
ChoiseFunctionProgramm();

void PrintArr (string [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i += 1)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int ChackingLengthForNewArr (string [] userArr)
{
    int count = 0;
    for(int i = 0; i < userArr.Length; i += 1)
    {
        
        if (userArr[i].Length <= 3) count +=1;
    }
    return count;
}

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
PrintArr(exampleFirst);
string [] resultFirst = ChoiceELemsInArr(exampleFirst);
PrintArr(resultFirst);
PrintArr(exampleSecond);
string [] resultSecond = ChoiceELemsInArr(exampleSecond);
PrintArr(resultSecond);
PrintArr(exampleThird);
string [] resultThird = ChoiceELemsInArr(exampleThird);
PrintArr(resultThird);
