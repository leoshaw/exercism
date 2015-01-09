using System.Linq;

public class Bob
{
    public string Hey(string input)
    {
        if (IsSilence(input))
        {
            return "Fine. Be that way!";
        }
        else if (IsShouting(input))
        {
            return "Whoa, chill out!";
        }
        else if (IsQuestion(input))
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
    }

    private bool IsSilence(string input)
    {
        return input.Trim().Length == 0;
    }

    private bool IsQuestion(string input)
    {
        // last character is a question mark, ignoring trailing spaces
        return input.Trim().EndsWith("?");
    }

    private bool IsShouting(string input)
    {
        // has at least 1 character, and all upper case
        var alphas = input.Where(char.IsLetter);
        return alphas.Any() && alphas.All(char.IsUpper);
    }

}