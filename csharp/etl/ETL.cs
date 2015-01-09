using System.Collections.Generic;

public class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> input)
    {
        var result = new Dictionary<string, int>();

        foreach (var pair in input)
        {
            var score = pair.Key;
            var letters = pair.Value;
            foreach (var letter in letters)
            {
                result.Add(letter.ToLower(), score);
            }
        }

        return result;
    }
}