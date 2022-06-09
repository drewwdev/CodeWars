problem: https://www.codewars.com/kata/58649884a1659ed6cb000072/train/csharp

public class Kata
{
public static string UpdateLight(string current)
{
if (current == "green"){
return "yellow";
}
else if (current == "yellow"){
return "red";
}
return "green";
}
}
