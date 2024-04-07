namespace Proxy
{
    public class SmartTextReader : ITextReader
    {

        public string[,] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            string[,] textArray = new string[lines.Length, lines[0].Length];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    textArray[i, j] = lines[i][j].ToString();
                }
            }
            return textArray;
        }

        public void DisplayTextArray(string[,] textArray)
        {
            if (textArray != null)
            {
                for (int i = 0; i < textArray.GetLength(0); i++)
                {
                    for (int j = 0; j < textArray.GetLength(1); j++)
                    {
                        Console.Write(textArray[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Array is emty");
            }
        }

    }
}
