string[] mass1 = new string[6] {"257", "45", "hello", "world", "res","456"};
string[] mass2 = new string[mass1.Length];
void SecondArray(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}   
void PrintArray(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
SecondArray(mass1, mass2);
PrintArray(mass2);