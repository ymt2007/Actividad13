using System;
using System.Collections.Generic;

List<Curso> cursos = new List<Curso>();
Console.WriteLine("Cuantos cursos desea regsitrar?");
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n;i++)
{
    Curso c = new Curso();
    Console.WriteLine($"Curso {i+1}");
    Console.WriteLine("Nombre del curso: "); c.NombreCurso = Console.ReadLine();
    Console.WriteLine();
}
class Curso
{
    public string NombreCurso;
    public int Creditos;
    public double NotaPromedio;
    public string Rendimiento()
    {
        if (NotaPromedio > 0 && NotaPromedio <= 50) return "Bajo";
        else if (NotaPromedio <= 70) return "Aceptable";
        else return "Excelente";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Curso: {NombreCurso} Creditos: {Creditos} Promedio:{NotaPromedio:F2} Rendimiento: {Rendimiento()}");
    }
}