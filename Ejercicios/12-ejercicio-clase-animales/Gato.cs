using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }

    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");
    }

     public void Descripcion() 
    {
        Console.WriteLine("El gato es un animal muy juguetón");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El gato es un animal mediano");
    }

    private void OtroMetodo()
    {

    }
}