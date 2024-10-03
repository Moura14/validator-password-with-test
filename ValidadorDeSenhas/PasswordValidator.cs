using System.Text.RegularExpressions;

public class ValidatorPassword
{

    public bool isValid(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return false;
        }

        if (password.Length < 8)
        {
            return false;
        }

        if(!Regex.IsMatch(password, @"[A-Z]"))
        {
            return false;
        }

        if(!Regex.IsMatch(password, @"[a-z]"))
        {
            return false;
        }

        if(!Regex.IsMatch(password, @"[0-9]"))
        {
            return false;
        }

        return true;
    }
}