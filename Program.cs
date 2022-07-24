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
    string method = Console.ReadLine();
    
    if(method == "1") // Manual method of array input
    {
        Console.WriteLine("Please input the size of your string array");
        int size = Convert.ToInt32(Console.ReadLine());
        string [] array1 = new string[size];

        for(int i = 0; i < size; i++)
        {
            Console.Write("Please input " + (i + 1) + " element of the string array: ");
            array1[i] = Console.ReadLine();
        }

        return array1;
    }

    if(method == "2") // Download array data from Input.txt file!!! Is is necessary that in file one line consist one element only
    {
        Console.WriteLine("Your string array has been created from Input.txt file.");
        string[] array2 = File.ReadAllLines("Input.txt");
        
        return array2;
    }

    string[] array3 = {};
    return array3;
}

string[] FilteredArray(string[] array, int symbLenght)
{
    int size = array.Length;

    File.WriteAllText("Temp.txt",String.Empty); // Clear the Temp.txt file for new temporary records

    for(int i = 0; i < size; i++)
    {
        if(array[i].Length <= symbLenght)
        {
            File.AppendAllText("Temp.txt", array[i] + Environment.NewLine);
        }
    }

    string[] newArray = File.ReadAllLines("Temp.txt");

    return newArray;
} 

Console.Clear();

string[] mainArray = ArrayInput();
int symbLenghtSize = 3;// Lenght limitation for elements of newArray

string[] newArray = FilteredArray(mainArray, symbLenghtSize);

Console.WriteLine("Main string array:");
PrintArray(mainArray);
Console.WriteLine("New string array:");
PrintArray(newArray);