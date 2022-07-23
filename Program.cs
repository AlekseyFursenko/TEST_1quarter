void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] mainArray = {"1234", "asd", "qwer", "1264", "asd"};

PrintArray(mainArray);

int symbLenghtSize = 3;
int size = mainArray.Length;
int count = 0; // Count of elements in the mainArray with lenght less or iqual symbLenghtSize
string[] newArray = new string[size];

for(int i = 0; i < size; i++)
{
    if(mainArray[i].Length <= symbLenghtSize)
    {
        newArray[count] = mainArray[i];
        count++;
    }
}

PrintArray(newArray);
