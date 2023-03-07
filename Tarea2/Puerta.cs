namespace Tarea2;

public class Puerta
{
    public string color { get; set; }

    public Puerta()
    {
        color = "Café";
    }

    public void SetColor(string nuevoColor)
    {
        color = nuevoColor;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Soy una Puerta, mi color es {color}.");
    }
}
