using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace пр_6
{

    public class Figure
    {
        public string Name;
        public double Width;
        public double Height;

        public static Figure ReadTxtFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 3)
                throw new Exception("Некорректный формат файла.");

            return new Figure
            {
                Name = lines[0],
                Width = double.Parse(lines[1]),
                Height = double.Parse(lines[2])
            };
        }

        public static Figure ReadJsonFile(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Figure>(jsonContent);
        }

        public static Figure ReadXmlFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Figure));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Figure)serializer.Deserialize(reader);
            }
        }

        public static void SaveTxtFile(Figure figure, string file)
        {
            string[] lines = { figure.Name, figure.Width.ToString(), figure.Height.ToString() };
            File.WriteAllLines(file, lines);
            Console.WriteLine("Файл успешно сохранен в формате txt.");
        }

        public static void SaveJsonFile(Figure figure, string file)
        {
            string jsonContent = JsonConvert.SerializeObject(figure, Formatting.Indented);
            File.WriteAllText(file, jsonContent);
            Console.WriteLine("Файл успешно сохранен в формате json.");
        }

        public static void SaveXmlFile(Figure figure, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Figure));
            using (StreamWriter writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, figure);
            }
            Console.WriteLine("Файл успешно сохранен в формате xml.");
        }

    }
}
