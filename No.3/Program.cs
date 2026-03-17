using System;
using System.Collections.Generic;

List<Empleado> empleados=new List<Empleado>();
Console.WriteLine("Cuantos empleados desea ingresar?");
int n=int.Parse(Console.ReadLine());

class Empleado
{
    public string Nombre;
    public string Puesto;
    public double Salario;
    public double CalcularSalarioAnual() { return Salario * 12; }
    public double CalcularBono()
    {
        if (Salario >= 5000) return Salario * 0.15;
        else return Salario * 0.08;
    }
    public string ClasificarSalario()
    {
        if (Salario >= 7000) return "Salario alto";
        else if (Salario >= 4000) return "Salario medio";
        else return "Salario básico";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} Puesto: {Puesto}  Salario mensual: Q{Salario:F2} Salario anual: Q{ CalcularSalarioAnual():F2}  Bono: Q{ CalcularBono():F2} Nivel: { ClasificarSalario()}");
        
    }

}