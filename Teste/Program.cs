int salario = 1150;
int imp;

if (salario < 1000)
{
    imp = 0;
} else
{
    imp = ((salario - 150) * 15 / 100);
}

Console.WriteLine(imp);

Console.ReadLine();