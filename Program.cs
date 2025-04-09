namespace N9__YP__Task_2_09._04._2025
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "numbers.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Содержимое файла:");

            int componentCount = 0;
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                string[] numbers = line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
                componentCount += numbers.Length;
            }

            Console.WriteLine($"Количество компонентов: {componentCount}");
        }

    }
}
