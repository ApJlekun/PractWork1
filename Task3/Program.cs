//C:\Temp\ispp21\PractWork1\123.txt
Console.WriteLine("Введите имя файла:");
string fileName = Console.ReadLine();
Console.WriteLine("Введите текст для поиска:");
string searchText = Console.ReadLine();
if (!File.Exists(fileName))
{
    Console.WriteLine("Файл не существует.");
    return;
}

string[] lines = File.ReadAllLines(fileName);

Console.WriteLine($"Строки файла '{fileName}', содержащие текст '{searchText}':");
for (int i = 0; i < lines.Length; i++)
{
    if (lines[i].Contains(searchText))
    {
        Console.WriteLine($"Строка {i + 1}: {lines[i]}");
    }
}
