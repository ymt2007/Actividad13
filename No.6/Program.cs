using System;
using System.Collections.Generic;

Dictionary<int, Estudiante> estudiantes=new Dictionary<int ,Estudiante>();
Console.WriteLine("Cuantos estudiantes desea registrar?");
int n = int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Console.WriteLine($"Registro {i+1}");
    Console.WriteLine("Numero de carnet: ");
    int carnet=int.Parse(Console.ReadLine());
    Estudiante e=new Estudiante();
    Console.WriteLine("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Carrera: "); e.Carrera = Console.ReadLine();
    Console.WriteLine("Nota final: "); e.NotaFinal=double.Parse(Console.ReadLine());
    estudiantes[carnet] = e;
 }

class Estudiante
{
    public string Nombre;
    public string Carrera;
    public double NotaFinal;
    public string Estado()
    {
        if (NotaFinal >= 61) return "Aprobado";
        else return "Reprobado";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} Carrera: {Carrera} Nota final: {NotaFinal} Estado: {Estado()}");
    }
}