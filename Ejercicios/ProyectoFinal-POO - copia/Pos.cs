using System;
using System.Collections.Generic;

public class ProyectoFinal_POO
{
    public List<Producto> ListadeProductos { get; set; }
     public List<Cliente> ListadeClientes { get; set; }
    public ProyectoFinal_POO()
    {
        //LISTADO DE PRODUCTOS
        ListadeProductos = new List<Producto>();

        Producto a = new Producto("001", "Estufa       ", 0);
        Producto b = new Producto("002", "Microondas   ", 0);
        Producto c = new Producto("003", "Refrigeradora", 0);
        Producto d = new Producto("004", "Licuadora    ", 0);
        Producto e = new Producto("005", "Batidora     ", 0);
        Producto f = new Producto("006", "Lavadora     ", 0);

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
        ListadeProductos.Add(f);

       
       //LISTADO DE CLIENTES
        ListadeClientes = new List<Cliente>();

        Cliente g = new Cliente("1", "Maria Castillo");
        Cliente h = new Cliente("2", "Josue Enamorado");
        Cliente i = new Cliente("3", "Omar Lopez");
        Cliente j = new Cliente("4", "Javier Ramirez");
        Cliente k = new Cliente("5", "Rubi Delcid");
        Cliente l = new Cliente("6", "Alexandra Maldonado");
        Cliente m = new Cliente("7", "Kenia Rodriguez");
        Cliente n = new Cliente("8", "Heidy Bardales");
        Cliente o = new Cliente("9", "Samuel Salgado");
        Cliente p = new Cliente("10","Rosa Mendez");
        
       

        ListadeClientes.Add(g);
        ListadeClientes.Add(h);
        ListadeClientes.Add(i);
        ListadeClientes.Add(j);
        ListadeClientes.Add(k);
        ListadeClientes.Add(l);
        ListadeClientes.Add(m);
        ListadeClientes.Add(n);
        ListadeClientes.Add(o);
        ListadeClientes.Add(p);
        
}

       //PRODUCTOS
 public void listarProductos() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("Electrodomésticos J&J");
        Console.WriteLine("*********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }

        Console.ReadLine();
    }


        //CLIENTES
    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Listado de Clientes");
        Console.WriteLine("Electrodomésticos J&J");
        Console.WriteLine("*********************");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " " );
        }

        Console.ReadLine();
    }



        //MOVIMIENTO POS
     private void movimientoPos(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

      

      //INGRESO DE PRODUCTOS EN EXISTENCIA 
    public void ingresoDeProducto() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos en Existencia");
        Console.WriteLine("     Electrodomésticos J&J        ");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoPos(codigo, Int32.Parse(cantidad), "+");
    
    }
    
    //SALIDA DE PRODUCTOS 
    public void salidaDeProducto() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine(" Salida de Productos ");
        Console.WriteLine("Electrodomésticos J&J");
        Console.WriteLine("*********************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoPos(codigo, Int32.Parse(cantidad), "-");
}

     //INGRESO DE VENTA


}