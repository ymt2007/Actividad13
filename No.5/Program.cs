using System;
using System.Collections.Generic;
List<Venta> ventas=new List<Venta>();
Console.WriteLine("Cuantas ventas desea registrar?");
int n=int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Venta v=new Venta();
    Console.WriteLine($"Venta {i+1}");
    Console.WriteLine("Producto: "); v.Producto = Console.ReadLine();
    Console.WriteLine("Precio: "); v.Precio=double.Parse(Console.ReadLine());
    Console.WriteLine("Cantidad: "); v.Cantidad=int.Parse(Console.ReadLine());
    ventas.Add(v);
}
Console.Clear();
double total = 0;
Console.WriteLine("Ventas registrada");
foreach(Venta v in ventas)
{
    v.MostrarInformacion();
    total += v.MontoTotal();
}
Console.WriteLine($"Total de ventas: {total:F2}");
class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;
    public double Subtotal()
    {
        return (Precio * Cantidad);
    }
    public double Descuento()
    {
        if (Subtotal() > 2000) return Subtotal() * 0.10;
        else if (Subtotal() >= 1000) return Subtotal() * 0.05;
        else return 0;
    }
    public double MontoTotal()
    {
        return Subtotal()-Descuento();
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Producto} Precio: {Precio} Cantidad; {Cantidad} Subtotal: {Subtotal():F2} Descuento:{Descuento():F2} Total a pagar: {MontoTotal():F2}");
    }
}