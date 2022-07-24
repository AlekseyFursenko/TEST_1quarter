void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] mainArray = {"1234", "asd", "qwer", "1264", "^)", ":-)"};

Console.WriteLine("Main string array:");
PrintArray(mainArray);

int symbLenghtSize = 3;
int size = mainArray.Length;
int count = 0; // Count of elements in the mainArray with lenght less or iqual symbLenghtSize

File.WriteAllText("Temp.txt",String.Empty); // Clear the txt file for new temporary records

string[] newArray = new string[size];

for(int i = 0; i < size; i++)
{
    if(mainArray[i].Length <= symbLenghtSize)
    {
        File.AppendAllText("Temp.txt", mainArray[i] + Environment.NewLine);
        count++;
    }
}

Console.WriteLine("New string array:");
Console.WriteLine(File.ReadAllText("Temp.txt"));