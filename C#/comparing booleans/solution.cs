// problem: https://www.codewars.com/kata/568dcc3c7f12767a62000038/train/csharp

public class Kata {
    public static bool SetAlarm(bool employed, bool vacation) 
    {
        if (employed == true && vacation == true)
        {
            return false;
        }
        else if (employed == false && vacation == true)
        {
            return false;
        }
        else if (employed == false && vacation == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}
