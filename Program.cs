// аписать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

string[] array1 = new string[5] {"1", "12", "123", "1234", "12345"};
string[] array2 = new string[array1.Length];

void MyArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length < 4)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }    
}
MyArray(array1, array2);
GetArray(array2);