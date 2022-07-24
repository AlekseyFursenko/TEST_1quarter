void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] ArrayInput()
{
    Console.WriteLine("Please choose the method of the main string array creation" + "\n" +
                    "1 - manualy" + "\n" +
                    "2 - from Input.txt file");
    int method = Convert.ToInt32(Console.ReadLine());
    
    if(method == 1)
    {
        Console.WriteLine("Please input the size of your string array");
        int size = Convert.ToInt32(Console.ReadLine());
        string [] array = new string[size];

        for(int i = 0; i < size; i++)
        {
            Console.Write("Please input " + (i + 1) + "element of the string array: ");
            array[i] = Console.ReadLine();
        }

        return array;
    }
    if(method == 2)
    {
        Console.WriteLine("Please input the size of your string array")
    }

    return array;
}

// Main array create
Console.Clear();



string[] mainArray = ArrayInput();

Console.WriteLine("Main string array:");
PrintArray(mainArray);

int symbLenghtSize = 3;
int size = mainArray.Length;

File.WriteAllText("Temp.txt",String.Empty); // Clear the txt file for new temporary records

for(int i = 0; i < size; i++)
{
    if(mainArray[i].Length <= symbLenghtSize)
    {
        File.AppendAllText("Temp.txt", mainArray[i] + Environment.NewLine);
    }
}

string[] newArray = File.ReadAllLines("Temp.txt");

Console.WriteLine("New string array:");

PrintArray(newArray);