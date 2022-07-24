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

Console.Clear();

string[] mainArray = ArrayInput();

Console.WriteLine("Main string array:");
PrintArray(mainArray);

int symbLenghtSize = 3;// Lenght limit limitation for elemrnts of newArray

int size = mainArray.Length;

File.WriteAllText("Temp.txt",String.Empty); // Clear the Temp.txt file for new temporary records

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