using System;
using System.Collections.Generic;

public class ProyectoFinal_POO
{
    public List<Usuario> ListadeUsuario { get; set; }
    public List<Producto> ListadeProductos { get; set; }
     public List<Cliente> ListadeClientes { get; set; }

    public List<Venta> ListaVenta { get; set; }
    public ProyectoFinal_POO()
    {
      ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeUsuario = new List<Usuario>();
        cargarUsuario();

        ListaVenta = new List<Venta>();
    }

//CARGAR USUARIOS
    private void cargarUsuario()
    {
        Usuario u1 = new Usuario(1, "Limny", "LL01");
        ListadeUsuario.Add(u1);

        Usuario u2 = new Usuario(2, "Josue", "JE02");
        ListadeUsuario.Add(u2);
        
        Usuario u3 = new Usuario(3, "Jared", "JC03");
        ListadeUsuario.Add(u3);
    }

    //CARGAR PRODUCTOS
    private void cargarProductos()
    {
        
        Producto p1 = new Producto(1,   "Estufa       ",  100);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2,   "Refrigeradora",  500);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3,   "Microondas   ",  200);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4,   "Licuadora    ",  900);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5,   "Batidora     ",   800);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6,   "Lavadora     ",   400);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7,   "Horno        ",   300);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8,   "Secadora     ",   450);
        ListadeProductos.Add(p8);

    }

    //CARGAR CLIENTES
    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Rubi Castillo ", "2647-6689");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Javier Ramirez", "91589475 ");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Roberto Avila ", "2647-4444");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Rosa Sanchez  ", "94265897 ");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Maria Ramos   ", "2648-2648");
        ListadeClientes.Add(c5);
    }


       //LISTADO DE PRODUCTOS
 public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("         Listado de Productos         ");
        Console.WriteLine("        Electrodomésticos J&J         ");
        Console.WriteLine("**************************************");
        Console.WriteLine("Código|     Producto      |     Precio");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + "     |     "      + producto.Descripcion + " |       " + producto.Precio);
        }

        Console.ReadLine();
    }


     //LISTADO DE CLIENTES
    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("         Listado de Clientes        ");
        Console.WriteLine("       Electrodomésticos J&J        ");
        Console.WriteLine("************************************");
        Console.WriteLine("Código|        Cliente    | Teléfono");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + "     |    " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

     //LISTADO DE USUARIOS
    public void ListarUsuarios()
    {
        Console.Clear();
        Console.WriteLine("   Listado de Usuarios    ");
        Console.WriteLine("  Electrodomésticos J&J   ");
        Console.WriteLine("**************************");
        Console.WriteLine("Código|Usuario| CodUsuario");
        Console.WriteLine("");
        
        foreach (var usuario in ListadeUsuario)
        {
            Console.WriteLine(usuario.Codigo + "    | " + usuario.Nombre + "  | " + usuario.CodigoUsuario);
        }

        Console.ReadLine();

    }

     //INGRESO DE NUEVA VENTA
     public void CrearVenta()
    {
        Console.Clear();
        Console.WriteLine("                 Ingreso de Ventas                          ");
        Console.WriteLine("               Electrodomésticos J&J                        ");
        Console.WriteLine("************************************************************");
        Console.WriteLine("");

         Console.WriteLine("Ingrese el codigo de Usuario: ");
        string codigoUsuario = Console.ReadLine();

        Usuario usuario = ListadeUsuario.Find(v => v.Codigo.ToString() == codigoUsuario);
        if (usuario == null) 
        {
            Console.WriteLine("Usuario no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Usuario: " + usuario.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

       

        int nuevoCodigo = ListaVenta.Count + 1;

        Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now, "El Progreso, Yoro" + nuevoCodigo, cliente, usuario);
        ListaVenta.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea agregar otro producto? si/no");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Subtotal de la venta es de: " + nuevaVenta.Subtotal);
        Console.WriteLine("Impuesto de la venta es de: " + nuevaVenta.Impuesto);
        Console.WriteLine("Total de la venta es de: " + nuevaVenta.Total);
        Console.ReadLine();
    }
    
      //REPORTE DE VENTAS
    public void ListarVentas()
    {
        Console.Clear();
        Console.WriteLine("                                                    Reporte de Ventas                                                  ");
        Console.WriteLine("                                                  Electrodomésticos J&J"                                                );
        Console.WriteLine("***********************************************************************************************************************");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha              |Producto       | Cantidad |Precio | Subtotal | Impuesto | Total | Cliente       | Usuario ");
        Console.WriteLine("***********************************************************************************************************************");
        Console.WriteLine("");  

        foreach (var venta in ListaVenta)
        foreach (var detalle in venta.ListaVentaDetalle)
        {
            Console.WriteLine(venta.Codigo + "   | " + venta.Fecha + "| " + detalle.Producto.Descripcion + " |        " + detalle.Cantidad + " | " + detalle.Precio +"   |  "+ venta.Subtotal + "      |  " + venta.Impuesto + "     |" + venta.Total + "    | " + venta.Cliente.Nombre +"|   " + venta.Usuario.Nombre); 
            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}