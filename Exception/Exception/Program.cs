
class Program
{
    static void Main(string[] args)
    {
        string filePath = "";
        try
        {
            List<int> scores = new List<int>();
            string? line;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        int score = int.Parse(line);
                        if (score < 0 || score > 100)
                            throw new ArgumentOutOfRangeException("score must be between 0 to 100");
                        scores.Add(score);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Invalid number format at {line}");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message );
                    }
                   
                }
            }
            if (scores.Count > 0)
            {
                double averageScore = CaculcateAverageScore(scores);
                Console.WriteLine($"Scores{averageScore:F2}");
            }
            else
            {
                Console.WriteLine("No valid scores to process");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found{filePath}");
        }
        catch(IOException ex)
        {
            Console.WriteLine($"IO error{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program finished Execution");
        }
    }

    static double CaculcateAverageScore(List<int> scores)
    {
        int total = 0;
        foreach (int score in scores)
        {
            total += score;
        }
        return total / scores.Count;
    }
}