using System;
public class Mono: Mamifero
{
    public string Habilidad{ get; set; }

    public void Maullar()
    {
        Console.WriteLine("Uaa uaa uaa");
    }

    public void Descripcion() 
    {
        Console.WriteLine("El mono es un experto en balancearse");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El mono es un animal mediano");
    }

    private void OtroMetodo()
    {

    }
}