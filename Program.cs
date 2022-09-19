void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}


string[] array = { "London", "is", "the", "capital", "of", "Great", "Britan" };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

if (count == 0) count++;

string[] newArray = new string[count];

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lastArray[j] = array[i];
        j++;
    }
}

PrintArray(newArray);