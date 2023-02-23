using System.Text.RegularExpressions;

string text = "Two swindlers arrive at the capital city of an emperor who spends lavishly on clothing at the\r\nexpense of state matters. Posing as weavers, they offer to supply him with magnificent\r\nclothes that are invisible to those who are stupid or incompetent. The emperor hires them,\r\nand they set up looms and go to work. A succession of officials, and then the emperor\r\nhimself, visit them to check their progress. Each sees that the looms are empty but pretends\r\notherwise to avoid being thought a fool. Finally, the weavers report that the emperor's suit is\r\nfinished. They mime dressing him and he sets off in a procession before the whole city. The\r\ntownsfolk uncomfortably go along with the pretense, not wanting to appear inept or stupid,\r\nuntil a child blurts out that the emperor is wearing nothing at all. The people then realize\r\nthat everyone has been fooled. Although startled, the emperor continues the procession,\r\nwalking more proudly than ever.";
string[] digits = Regex.Split(text, @"\s");
string pattern = "^[Ee]mperor";
Regex regex = new Regex(pattern);

int index = 0;
List<int> empororIndexes = new List<int>();
foreach (string digit in digits)
{
    if (regex.IsMatch(digit)) empororIndexes.Add(index);
    index++;
}


Console.WriteLine("OPGAVE 1");
foreach (var ind in empororIndexes)
{
    Console.WriteLine(ind);
}
Console.WriteLine("OPGAVE 1 SLUT");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("OPGAVE 2");
string teacher = Regex.Replace(text, @"[Ee]mperor", "teacher");
Console.WriteLine(teacher);
Console.WriteLine("OPGAVE 2 SLUT");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("OPGAVE 3");
string replaced = Regex.Replace(text, @"\r\n", " ");
string[] lines = Regex.Split(replaced, @"\. ");
foreach(string line in lines)
{
    Console.WriteLine(line);
}
Console.WriteLine("OPGAVE 3 SLUT");
