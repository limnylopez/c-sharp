using System;
public class Aguila: Aves
{
    public string Color { get; set; }

    public void Vuelo()
    {
        Console.WriteLine("Vuelo Alto");
    }

      public void Descripcion() 
    {
        Console.WriteLine("El Águila es un animal muy ágil");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El Águila es un animal mediano");
    }

    private void OtroMetodo()
    {

    }
}