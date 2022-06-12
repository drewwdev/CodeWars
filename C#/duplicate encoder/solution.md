problem: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

using System.Linq;

public class Kata
{
public static string DuplicateEncode(string word)
{
string newWord = "";
string lowerWord = word.ToLower();
foreach (char c in lowerWord){
int count = lowerWord.Count( x => x == c);
if (count > 1){
newWord += ")";
}
else {
newWord += "(";
}
}
return newWord;
}
}
