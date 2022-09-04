using System.Text.RegularExpressions;
string[] phoneBook ={ "Biloshapka Ivan - 380996160201", "Aunt - 380660214586" };
List<string> result = new List<string>();
Console.WriteLine("Введите номер или Имя ");
string? str = Console.ReadLine();
Regex regex = new Regex(str);
try
{
    foreach (var person in phoneBook)
    {
        MatchCollection matches = regex.Matches(person);
        if (matches.Count > 0)
        {
            result.Add(person);
        }
    }

    if (result.Count > 0)
    {
        Console.WriteLine("Matches:");
        foreach (var person in result)
        {
            Console.WriteLine(person);
        }
    }
    else
    {
        Console.WriteLine("Doesn't exist");
    }
}
catch (Exception ex) { }
//checked
