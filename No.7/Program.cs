using System;
using System.Collections.Generic;

Dictionary<string, Producto> productos= new Dictionary<string, Producto>();
Console.WriteLine("Cuantos productos desea ingresar?");
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
    Console.WriteLine($"Producto {i+1}");
    Console.WriteLine("Ingrese el codigo del producto");
    string codigo = Console.ReadLine();
    Producto p=new Producto();
    Console.WriteLine("Nombre del producto: "); p.Nombre=Console.ReadLine();
    Console.WriteLine("Precio: "); p.Precio=double.Parse(Console.ReadLine());
    Console.WriteLine("Disponibles: "); p.Stock=int.Parse(Console.ReadLine());
    productos[codigo] = p;
}
Console.Clear();
Console.WriteLine("Productos registrados");
foreach(KeyValuePair<string, Producto> item in productos)
{
    Console.Write($"Codigo: {item.Key} ");
    item.Value.MostrarInformacion();
}
string op;
do
{
    Console.WriteLine("Desea buscar un producto en especifico? (s/n)");
    op = Console.ReadLine();
    Console.Clear();
    if (op == "s")
    {
        Console.WriteLine("Ingrese el codigo del producto a buscar");
        string buscar = Console.ReadLine();
        if (productos.ContainsKey(buscar))
        {
            Console.WriteLine("Producto encontrado");
            productos[buscar].MostrarInformacion();
        }
        else
        {
            Console.WriteLine("Producto no encontrado");
        }
    }
} while (op != "n");
class Producto
{
    public string Nombre;
    public double Precio;
    public int Stock;
    public string EvaluarEstado()
    {
        if (Stock == 0) return "Agotado";
        else if (Stock <= 4) return "Bajo";
        else return "Normal";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre} Precio: {Precio} Disponibles: {Stock} Estado: {EvaluarEstado()}");
    }

}