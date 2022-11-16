#region qeyd
//run ederken suallari tek tek run edin,diger suallari coment'e atin.
#endregion

#region 2-nin quvveti olmasi
restart:
Console.WriteLine("Ededi daxil edin:");
string astr = Console.ReadLine();
int a = Convert.ToInt32(astr);
while (a > 2)
{
    a /= 2;

}
if (a == 2)
{
    Console.WriteLine("Eded 2-nin quvvetidir");
}
else
{
    Console.WriteLine("Eded 2-nin quvveti deyil");
}
goto restart;
#endregion

#region 2 eded arasinda olan ededler
restrart2:
Console.Write("Ilk ededi qeyd edin: ");
string bstrg = Console.ReadLine();
Console.WriteLine("Qeyd:Ilk eded ikinciden kicik olmalidir.");
Console.Write("Ikinci ededi qeyd edin: ");
string cstrg = Console.ReadLine();
int b = Convert.ToInt32(bstrg);
int c = Convert.ToInt32(cstrg);
if (b < c)
{
    for (int o = b + 1; o < c; o++)
    {
        Console.WriteLine(o);
    }
}
else
{
    Console.WriteLine("Ilk eded ikinciden boyukdur,yeniden teyin edin");
    goto restrart2;
}
#endregion

#region 70 den boyukdur serti
restart3:
Console.Write("Ededi daxil edin: ");
string dstrg = Console.ReadLine();
int d = Convert.ToInt32(dstrg);
int result = 0;
if (d > 70)
{
    result = d - 70;
    result *= 3;
    Console.WriteLine("Result:" + result);
}
else
{
    result = 70 - d;
    Console.WriteLine("Result:" + result);
}
goto restart3;
#endregion

#region 3 ededden en boyuyu secen
restart4:
Console.Write("Ilk ededi daxil edin: ");
string estrg = Console.ReadLine();

Console.Write("Ikinci ededi daxil edin: ");
string fstrg = Console.ReadLine();

Console.Write("Ucuncu ededi daxil edin: ");
string gstrg = Console.ReadLine();

double e = Convert.ToDouble(estrg);
double f = Convert.ToDouble(fstrg);
double g = Convert.ToDouble(gstrg);

if (e > f)
{
    if (e > g)
    {
        Console.WriteLine("En boyuk eded:" + e);
    }
}
else
{
    if (f > g)
    {
        Console.WriteLine("En boyuk eded:" + f);
    }
    else
    {
        Console.WriteLine("En boyuk eded:" + g);
    }
}
goto restart4;

#endregion

#region araliqdaki tek eded sayi
restart5:
Console.Write("Ilk ededi daxil edin: ");
string hstrg = Console.ReadLine();
Console.Write("Qeyd:ilk eded ikinciden kicik olamlidir \n Ikinci ededi daxil edin: ");
string pstrg = Console.ReadLine();

int h = Convert.ToInt32(hstrg);
double p = Convert.ToDouble(pstrg);
int h1 = h % 2;
int i = 0;
while (h > p)
{
    Console.WriteLine("Ilk eded ikinciden boyukdur yeniden teyin edin");
    goto restart4;
}
if (h1 == 0)
{
    h++;
    for (i = 0; h < p; i++)
    {
        h += 2;

    }
    Console.WriteLine("Result:" + i);
}
else
{
    h += 2;
    for (i = 0; h < p; i++)
    {
        h += 2;
    }
    Console.WriteLine("Result:" + i);
}
goto restart5;
#endregion