using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using пр_6;

Console.WriteLine("Добро пожаловать в текстовый редактор!");
Console.Write("Введите путь к файлу: ");
string filePath = Console.ReadLine();

if (!File.Exists(filePath))
{
    Console.WriteLine("Файл не найден.");
    return;
}


Figure figure = new Figure();

if (filePath.EndsWith(".txt"))
{

    figure = Figure.ReadTxtFile(filePath);

}
else if (filePath.EndsWith(".json"))
{
    figure = Figure.ReadJsonFile(filePath);

}
else if (filePath.EndsWith(".xml"))
{
    figure = Figure.ReadXmlFile(filePath);
}
else
{
    Console.WriteLine("Формат файла не поддерживается.");

}

Console.WriteLine("Прочитанные данные:");
Console.WriteLine("  Название:" + figure.Name);
Console.WriteLine("  Ширина:" + figure.Width);
Console.WriteLine("  Высота: " + figure.Height);
ConsoleKeyInfo keyInfo;
do
{
    keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.F1)
    {
        Console.Clear();
        Console.WriteLine("Введите путь куда нужно сохранить файл");
        Console.WriteLine("-------------------------------------");
        string file = Console.ReadLine();

        if (file.EndsWith(".txt"))
        {

            Figure.SaveTxtFile(figure, file);
            break;
        }
        else if (file.EndsWith(".json"))
        {
            Figure.SaveJsonFile(figure, file);
            break;
        }
        else if (file.EndsWith(".xml"))
        {
            Figure.SaveXmlFile(figure, file);
            break;
        }
        else
        {
            Console.WriteLine("Формат файла не поддерживается.");

        }
    }
} while (keyInfo.Key != ConsoleKey.Escape);

