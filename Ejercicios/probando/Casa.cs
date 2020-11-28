using System;
public class Casa
{
    //Estados - Atributos
    public string direccion;
    public string color;
    public string techo;
    public double areaConstruida;
    public double areaTerreno;
    public int numDormitorios;
    public int numPisos;
    public int numBaños;

    //Comportamientos - Métodos
    public void vender()
    {
        Console.WriteLine("Casa "+ color+" de "+areaTerreno+" metros cuadrados de terreno ha sido VENDIDA\nMas detalles:");
        Console.WriteLine("\tDireccion: "+direccion);
        Console.WriteLine("\tColor: " + color);
        Console.WriteLine("\tTecho: " + direccion);
        Console.WriteLine("\tArea construida: " + areaConstruida);
        Console.WriteLine("\tArea de terreno: " + areaTerreno);
        Console.WriteLine("\tCantidad de dormitorios: " + numDormitorios);
        Console.WriteLine("\tCantidad de pisos: " + numPisos);
        Console.WriteLine("\tCantidad de baños: " + numBaños);
    }

    public void Alquilar()
    {
        Console.WriteLine("Casa " + color + " de" + areaTerreno + " metros cuadrados de terreno a sido ALQUILADA\nMas detalles:");
        Console.WriteLine("\tDireccion: " + direccion);
        Console.WriteLine("\tColor: " + color);
        Console.WriteLine("\tTecho: " + direccion);
        Console.WriteLine("\tArea construida: " + areaConstruida);
        Console.WriteLine("\tArea de terreno: " + areaTerreno);
        Console.WriteLine("\tCantidad de dormitorios: " + numDormitorios);
        Console.WriteLine("\tCantidad de pisos: " + numPisos);
        Console.WriteLine("\tCantidad de baños: " + numBaños);
    }
}