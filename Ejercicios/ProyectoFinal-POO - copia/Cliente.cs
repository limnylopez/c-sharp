using System;
using System.Collections.Generic;
public class Cliente
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }

    public Cliente(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }

}