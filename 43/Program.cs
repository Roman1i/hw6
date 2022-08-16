Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

// double findx(double b1, double k1, double b2, double k2)
// {
//     double tmp =  b2 - b1;
//     double tmp2 = k1 - k2;
//     double res = tmp/  tmp2;
//     return res;
// }
double tmp =  b2 - b1;
double tmp2 = k1 - k2;
double x = tmp/  tmp2;
double y = 5*x +2;
Console.WriteLine("("+x+";"+y+")");
