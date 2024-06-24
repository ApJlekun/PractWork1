//C:\Temp\ispp21\PractWork1\123.txt
Console.WriteLine("Введите имя файла:");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
{
    Console.WriteLine($"Файл с именем '{fileName}' открыт на дозапись.");
}
else
{
    Console.WriteLine($"Файл с именем '{fileName}' будет создан.");
}

string text = "";
while (text != "end")
{
    text = Console.ReadLine();
    if (text != "end")
    {
        File.AppendAllText(fileName, text+Environment.NewLine);
    }
}

Console.WriteLine("Запись в файл завершена.");

