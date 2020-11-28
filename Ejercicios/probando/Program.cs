    class Program
    {
        static void Main(string[] args)
        {
            Casa objetoCasa = new Casa();//instanciamos
            //Inicializamos los atributos, asignar-definir valores
            objetoCasa.direccion = "Av José";
            objetoCasa.color = "Blanco";
            objetoCasa.techo = "Tejas";
            objetoCasa.areaConstruida = 239;
            objetoCasa.areaTerreno = 145;
            objetoCasa.numDormitorios = 5;
            objetoCasa.numPisos = 2;
            objetoCasa.numBaños = 3;
            //invocamos un metodo-comportamiento
            objetoCasa.vender();
        }
    }