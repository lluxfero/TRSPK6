using System.Globalization;
using System.Text;

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


string s = "Привет, мир, й, ёЁ!\nHello world!\nÁ Ã ä Ü æ © £ ¢ ";
File.WriteAllText("textUFT8", s, Encoding.UTF8);
File.WriteAllText("textUnicode", s, Encoding.Unicode);
File.WriteAllText("textLatin1", s, Encoding.Latin1);
File.WriteAllText("textASCII", s, Encoding.ASCII);
Console.WriteLine($"UFT8:\n{File.ReadAllText("textUFT8", Encoding.UTF8)}\n");
Console.WriteLine($"Unicode:\n{File.ReadAllText("textUnicode", Encoding.Unicode)}\n");
Console.WriteLine($"Latin1:\n{File.ReadAllText("textLatin1", Encoding.Latin1)}\n");
Console.WriteLine($"ASCII:\n{File.ReadAllText("textASCII", Encoding.ASCII)}\n");

