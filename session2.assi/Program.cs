#region Q1
//????
#endregion

#region Q2
//???
#endregion

#region Q3
int pagesF = 464;
int pagesR = int.Parse("464");
Console.WriteLine(pagesR);
#endregion

#region Q4
//10/0 doesnt work
int n = 10;
int d = 0;

try
{
    int result = n / d;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
#endregion

#region Q5
int pages = 300;
double pageD = pages;
Console.WriteLine(d);
#endregion

#region Q6
double price = 49.99;
int resault = (int)price;
Console.WriteLine(resault);
#endregion

#region Q7
string pagesText = "464";
int pages1 = Convert.ToInt32(pagesText);
Console.WriteLine(pages1);
#endregion

#region Q8
string yearText = "2023";
int year = int.Parse((string)yearText);

string badText = "abc";
if (int.TryParse(badText, out int result1))
{
    Console.WriteLine($"Converted: {result1}");
}
else
{
    Console.WriteLine("Invalid number");
}
#endregion

#region Q9
int pages2 = 464;
string pagesString = pages2.ToString();
Console.WriteLine(pagesString);
Console.WriteLine(pagesString.GetType());
#endregion

#region Q10
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;

Console.WriteLine(copies);
Console.WriteLine(boxed);
Console.WriteLine(unboxed);
#endregion

#region Q11
int? year1 = null;
Console.WriteLine(year1.HasValue);

year1 = 2023;
Console.WriteLine(year1.HasValue);
Console.WriteLine(year1.Value);
#endregion

#region Q12
string? reviewer = null;
Console.WriteLine(reviewer is null); //or ==null
#endregion

#region Q13
string? book1 = null;
string? title1 = book1;
Console.WriteLine(title1 is null);
#endregion

#region Q14
Console.WriteLine(title1 ?? "Untitled");

title1 ??= "Untitled";
Console.WriteLine(title1);
#endregion

#region Q15
string? name = "Ahmed";
string confirmedName = name!;
Console.WriteLine(confirmedName);
#endregion