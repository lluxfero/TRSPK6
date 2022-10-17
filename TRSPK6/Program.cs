using System.Globalization;

float pi = 3.14F;
DateTime dt = DateTime.Now;
string a = "5,5";
string b = "01.12.2020 00:03:02";

Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"{pi.ToString()}\n{dt.ToString()}");
Console.WriteLine($"{double.Parse(a)}\n{DateTime.Parse(b)}\n");

string a2 = "5.5";
CultureInfo.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"{pi.ToString()}\n{dt.ToString()}");
Console.WriteLine($"{double.Parse(a)}\n{double.Parse(a2)}\n{DateTime.Parse(b)}\n");

CultureInfo.CurrentCulture = new CultureInfo("ja-JP");
Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"{pi.ToString()}\n{dt.ToString()}");
Console.WriteLine($"{double.Parse(a)}\n{double.Parse(a2)}\n{DateTime.Parse(b)}\n");

CultureInfo.CurrentCulture = new CultureInfo("th-TH");
Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
Console.WriteLine($"{pi.ToString()}\n{dt.ToString()}");
Console.WriteLine($"{double.Parse(a)}\n{double.Parse(a2)}\n{DateTime.Parse(b)}\n");