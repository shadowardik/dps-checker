using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "dps.txt";
        string outputFilePath = "result.txt";

        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine($"Файл {inputFilePath} не найден.");
            return;
        }

        string[] detects = { "!2024/06/18:20:06:26", "!2023/11/11:12:57:00", "!2024/11/22:18:20:27", "!2076/05/18:04:53:15", "2024/05/02:22:48", "!2022/07/08:23:42:38", "!2024/09/06:09:35:50", "2019/08/16:16:17:36", "!2023/07/03:22:01:11", "!2023/10/04:16:07:05" };
        string[] descriptions = { "troxill client", "cortex client", "blessed client", "unicorn fakelags", "niobium client", "takker", "ocean antiacheat bypass", "drip x client", "avalone", "avalone" };

        try
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in lines)
                {
                    for (int i = 0; i < detects.Length; i++)
                    {
                        if (line.Contains(detects[i]))
                        {
                            writer.WriteLine($"{line} - ({descriptions[i]})");
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}