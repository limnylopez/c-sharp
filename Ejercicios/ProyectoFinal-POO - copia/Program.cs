using System;

namespace Pos
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcion = "";
            ProyectoFinal_POO pos = new ProyectoFinal_POO();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("   SISTEMA DE POS    ");
                Console.WriteLine("Electrodomésticos J&J");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Listado de Productos");
                Console.WriteLine("2 - Listado de Clientes");
                Console.WriteLine("3 - Ingreso de productos");
                Console.WriteLine("4 - Salida de productos");
                Console.WriteLine("5 - Ingreso de venta");
                Console.WriteLine("6 - Reporte de ventas");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        pos.listarProductos();
                        break;
                    
                    case "2": 
                        pos.ListarClientes();
                        break;
                    
                    case "3": 
                        pos.ingresoDeProducto();
                        break;
                    
                    case "4": 
                        pos.salidaDeProducto();
                        break;
                                
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}
