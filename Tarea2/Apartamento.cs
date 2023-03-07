namespace Tarea2;

public class Apartamento : Casa
{
    public Apartamento() : base(50)
    {
    }

    public new void MostrarDatos()
    {
        Console.WriteLine($"Soy un Apartamento, mi área es {area} m2.");
 }
}