problem: https://www.codewars.com/kata/57a429e253ba3381850000fb/train/csharp

public class Kata
{
public static string Bmi(double weight, double height)
{
double bmiCalc = weight / (height \* height);

        if (bmiCalc <= 18.5)
        {
          return "Underweight";
        }
        else if (bmiCalc <= 25.0)
        {
          return "Normal";
        }
        else if (bmiCalc <= 30.0)
        {
          return "Overweight";
        }
        else
        {
          return "Obese";
        }
    }

}
