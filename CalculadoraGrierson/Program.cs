using System;
namespace calculadorasangre
{
class Program
{
static void MostrarMenu()
{

Console.WriteLine("Que desea operar?");
Console.WriteLine("1-Hematocrito");
Console.WriteLine("2-Volumen Corpuscular Medio");
Console.WriteLine("3-Hemoglobina Corpuscular Media");
Console.WriteLine("4-Concentracion Hemoglobina Corpouscular Media");
}
static void Main(String[]args)
{
Console.WriteLine("Bienvenido a la calculadora de Sangre Grierson");
MostrarMenu();
int opcion =int.Parse(Console.ReadLine());
{
switch (opcion)
{
case 1:

Console.WriteLine("Ingrese Numero de Globulos Rojos");
int globroj = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Volumen en Sangre");
int volsan = int.Parse(Console.ReadLine());
int resul;
resul = globroj / volsan;
resul = 100 * resul;
Console.WriteLine("Ingrese Sexo del Paciente, ¿M o F?");
string sexo=Console.ReadLine();
if (sexo=="M")
{
    if (resul>=50.3)
    {
        Console.WriteLine("El resultado es = " + resul + "%");
        Console.WriteLine("Valores altos. Lo normal en hombres esta entre los 40,7% y 50,3%");
        MostrarMenu();
    }
    if (resul<=40.7)
    {
        Console.WriteLine("El resultado es = " + resul + "%");
        Console.WriteLine("Valores bajos. Lo normal en hombres esta entre los 40,7% y 50,3%");
        MostrarMenu();
    }
    else 
    {
        Console.WriteLine("El resultado es = " + resul + "%");
        MostrarMenu();
    }

}
else
{
    if (resul>=44.3)
    {
        Console.WriteLine("El resultado es = " + resul + "%");
        Console.WriteLine("Valores altos. Lo normal en mujeres esta entre los 36,1% y 44,3%");
    }
    if (resul<=36.1)
    {
        Console.WriteLine("El resultado es = " + resul + "%");
        Console.WriteLine("Valores bajos. Lo normal en mujeres esta entre los 36,1% y 44,3%");
    }
    else 
    {
        Console.WriteLine("El resultado es = " + resul + "%");
    }
}
break;


case 2:
Console.WriteLine("Ingrese nivel de Hematocritos");
int hemat = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese nivel de Globulos Rojos");
globroj = int.Parse(Console.ReadLine());

break;

case 3:
break;
case 4:
break;
default:
Console.WriteLine("Invalido");
break;
}
}
Console.ReadKey();
}
}
}
