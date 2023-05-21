string str = "abaacc";
int[] myArray = new int[str.Length];
char letter;
int counter = 0;
int result = 0;
for (int i = 0; i < str.Length; i++)
{
    letter = str[i];
    for (int j = 0; j < str.Length; j++)
    {
        if (letter == str[j])
        {
            counter++;
        }
        
    }

    myArray[i] = counter;
    counter = 0;
}

result = myArray.Max() - myArray.Min();
Console.WriteLine(result);

