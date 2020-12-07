using System;
public class Globo: Peces
{
    public string Color { get; set; }

    public void Inflarse()
    {
        Console.WriteLine("Inflarse");
    }

     public void Descripcion() 
    {
        Console.WriteLine("El pez globo es un tipo de pez muy común");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El pez globo es un animal pequeño");
    }

    private void OtroMetodo()
    {

    }
}