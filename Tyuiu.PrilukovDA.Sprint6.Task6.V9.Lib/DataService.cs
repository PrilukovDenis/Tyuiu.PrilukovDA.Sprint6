using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string[] lines = File.ReadAllLines(path);

            string result = "";

            foreach (string line in lines)
            {
                // удаляем лишние пробелы
                string trimmed = line.Trim();

                if (string.IsNullOrWhiteSpace(trimmed))
                    continue; // пропускаем пустые строки

                // разбиваем по пробелам/табам
                string[] words = trimmed.Split(
                    new char[] { ' ', '\t', '\n' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                if (words.Length > 0)
                {
                    string lastWord = words[words.Length - 1];
                    result += lastWord + " ";
                }
            }

            return result.TrimEnd();
        }
    }
}
