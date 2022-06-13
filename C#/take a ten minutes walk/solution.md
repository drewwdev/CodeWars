problem: https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp

using System.Linq;

public class Kata
{
public static bool IsValidWalk(string[] walk)
{
int location = 0;
foreach (string dir in walk){
if (dir == "n"){
location += 1;
if (!walk.Contains("s")){
return false;
}
}
else if (dir == "s"){
location -= 1;
if (!walk.Contains("n")){
return false;
}
}
else if (dir == "w"){
location += 1;
if (!walk.Contains("e")){
return false;
}
}
else {
location -= 1;
}
}
if (location == 0 && walk.Length == 10){
return true;
}
else {
return false;
}
}
}
