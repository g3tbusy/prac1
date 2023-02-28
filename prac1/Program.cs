using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.WriteLine("Type number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type number B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type number C");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--------");

Console.WriteLine("1) a^3-3a^2b+3ab^2-b^3=(a-b)^3");
int first = Convert.ToInt32(Math.Pow(a - b, 3));
Console.WriteLine($"     ({a} - {b})^3 = {first} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("2) a^3+3a^2b+3ab^2+b^3 = (a + b)^3");
int second = Convert.ToInt32(Math.Pow(a + b, 3));
Console.WriteLine($"     ({a} + {b})^3 = {second} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("3) (a+b)(a^2-ab+b^2) = a^3 + b^3");
int q = Convert.ToInt32(Math.Pow(a, 3));
int w = Convert.ToInt32(Math.Pow(b, 3));
int third = q + w;
Console.WriteLine($"     {a}^3 + {b}^3 = {third} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("4) (a-b)(a^2+ab+b^2) = a^3 - b^3");
int e = Convert.ToInt32(Math.Pow(a, 3));
int r = Convert.ToInt32(Math.Pow(b, 3));
int fourth = e - r;
Console.WriteLine($"     {a}^3 - {b}^3 = {fourth} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("5) (a - b) * (a + b) = a^2 - b^2");
int t = Convert.ToInt32(Math.Pow(a, 2));
int y = Convert.ToInt32(Math.Pow(b, 2));
int fifth = t - y;
Console.WriteLine($"     {a}^2 - {b}^2 = {fifth} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("6) a^2-2ab+b^2 = (a - b)^2");
int sixth = Convert.ToInt32(Math.Pow(a - b, 2));
Console.WriteLine($"     ({a} - {b})^2 = {sixth} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("7) a^2+2ab+b^2 = (a + b)^2");
int seventh = Convert.ToInt32(Math.Pow(a + b, 2));
Console.WriteLine($"     ({a} + {b})^2 = {seventh} // при а={a}, b={b}");

Console.WriteLine("--------");

Console.WriteLine("8) ((a^2-4bc)/(a - a^1/2-a^c)-(abc)^3)/(a^2-2ab+b^2) = ((a^2-4bc)/(a - a^1/2-a^c)-(abc)^3)/(a-b)^2");
int z = Convert.ToInt32(Math.Pow(a, 2));
int x = Convert.ToInt32(Math.Pow(a, 1 / 2));
int v = Convert.ToInt32(Math.Pow(a, c));
int n = Convert.ToInt32(Math.Pow(a * b * c, 3));
int m = Convert.ToInt32(Math.Pow(a - b, 2));
int eighth = ((z - 4 * b * c) / (a - x - v) - n) / m;
Console.WriteLine($"     (({a}^2-4*{b}*{c})/({a} - {a}^1/2-{a}^{c})-({a}*{b}*{c})^3)/({a}-{b})^2 = {eighth} // при а={a}, b={b}, c={c}");

Console.WriteLine("--------");