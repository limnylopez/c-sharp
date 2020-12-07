using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

            Mono m = new Mono();
            m.Nombre = "Jorge el Curioso";
            m.Patas = 2;
            m.Habilidad= "Balancearse";
            m.Comer();
            m.Maullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
           

            Aguila a = new Aguila();
            a.Nombre = "Ruda";
            a.Patas = 2;
            a.Color = "Café";
            a.Comer();
            a.Volar();
            a.Vuelo();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Loro l = new Loro();
            l.Nombre = "Paquito";
            l.Patas = 2;
            l.Color = "Verde";
            l.Comer();
            l.Volar();
            l.Hablar();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje);

            Globo pg = new Globo();
            pg.Nombre = "Nemo";
            pg.NumeroAletas = 3;
            pg.Color = "Gris";
            pg.Comer();
            pg.Nadar();
            pg.Inflarse();

            Console.WriteLine(pg.Nombre);
            Console.WriteLine(pg.NumeroAletas);


        }
        
    }
}