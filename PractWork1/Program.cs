//C:\Temp\ispp21\PractWork1\123.txt
Console.WriteLine("имя файла ");
string FileName = Console.ReadLine();
if (File.Exists(FileName))
{
    string fileContent = File.ReadAllText(FileName);
    Console.WriteLine(fileContent);
}
else
{
    Console.WriteLine("файла с данным именем не существует");
}

