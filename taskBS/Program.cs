string[] start = { "hello", "2", "world", ":-)"};
// string[] start = { "1234", "1567", "-2", "computer science"};
// string[] start = { "Russia", "Denmark", "Kazan"};

string[] NewStringArray(string[]array)
{
    int finLength = 0;
    for (int oldIndex = 0; oldIndex < array.Length; oldIndex++)
    {
        if(array[oldIndex].Length<=3) finLength++;
    }
    string[] resaltArr = new string [finLength];
    int newIndex = 0;
    for (int oldIndex = 0; oldIndex < array.Length; oldIndex++)
    {
        if(array[oldIndex].Length<=3)
        {
            resaltArr[newIndex] = array[oldIndex];
            newIndex++;
        }
    }
    return resaltArr;
}

string [] end = NewStringArray(start);

System.Console.WriteLine($"Старый массив из {start.Count()} элементов = [ {string.Join(", ", start)} ]");
System.Console.WriteLine($"Новый массив из {end.Count()} элементов = [ {string.Join(", ", end)} ]");