string[] start = { "hello", "2", "world", ":-)"};
// string[] start = { "1234", "1567", "-2", "computer science"};
// string[] start = { "Russia", "Denmark", "Kazan"};

string[] end = (from elm in start 
                where (elm.Length) <= 3 
                select elm).ToArray();

System.Console.WriteLine($"Старый массив из {start.Count()} элементов = [ {string.Join(", ", start)} ]");
System.Console.WriteLine($"Новый массив из {end.Count()} элементов = [ {string.Join(", ", end)} ]");