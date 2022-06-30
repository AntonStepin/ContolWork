
string[] CertainSizeOfElement(string[] InitialArray, int SizeOfElement)
{
    int NumberOfElements = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
        if (InitialArray[i].Length <= SizeOfElement)
        {
            NumberOfElements++;
        }

    }
    string[] ResultArray = new string[NumberOfElements];
    int ElementRA = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
        if (InitialArray[i].Length <= SizeOfElement)
        {
            ResultArray[ElementRA] = InitialArray[i];
            ElementRA++;
        }
    }
    return ResultArray;
}


void PrintArray(string[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < Array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string[] InitialArray =
{
    "hello",
    "2",
    "world",
    ":-)"
};
int SizeOfElement = 3;
string[] ArrayCertainElements = CertainSizeOfElement(InitialArray, SizeOfElement);
PrintArray(ArrayCertainElements);