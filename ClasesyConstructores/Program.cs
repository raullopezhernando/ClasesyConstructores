using System;

namespace ClasesyConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos a la clase cubo
            Cubo miCubo = new Cubo();
            Cubo cubo2 = new Cubo();

            //Instanciamos a la clase Prisma
            Prisma miPrisma = new Prisma();

            //Instanciamos a la clase Prisma para la versión sobrecargada
            Prisma miprisma2 = new Prisma(4, 3, 9);

            //Asignamos el valor de lado
            miCubo.lado = 5;
            cubo2.lado = 7;

            //Invocamos los metodos
            miCubo.CalcularArea();
            miCubo.CalcularVolumen();
            cubo2.CalcularArea();
            cubo2.CalcularVolumen();

            //miPrisma.Ancho = 7;

            //Invocar los metodos del prisma
            miPrisma.CalculaArea();
            miPrisma.CalculaVolumen();

            miprisma2.CalculaArea();
            miprisma2.CalculaVolumen();

            //Imprimimos los datos
            Console.WriteLine("Area={0}, Volumen={1}", miCubo.area, miCubo.volumen);
            //Mostramos cubo2
            Console.WriteLine("Area={0}, Volumen={1}", cubo2.area, cubo2.volumen);

            Console.WriteLine(miPrisma.ToString());

            miPrisma.ImprimirResultado();

            Console.WriteLine(miprisma2.ToString());



        }
    }

    class Cubo
    {
        //Declaramos los datos
        public int lado;
        public int area;
        public int volumen;

        //Método para calcular el área
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }

        //Método para calcular el volumen
        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }

    class Prisma
    {
        //Declaramos los datos
        private int ancho;
        private int alto;
        private int espesor;
        private int area;
        private int volumen;

        //Definiendo las propiedades
        public int Ancho
        {
            get
            {
                return ancho;
            }
            set
            {
                if (value <= 0)
                    ancho = 1;
                else
                    ancho = value;
            }
        }

        public int Alto
        {
            get
            {
                return alto;
            }
            set
            {
                if (value <= 0)
                    alto = 1;
                else
                    alto = value;
            }
        }

        public int Espesor
        {
            get
            {
                return espesor;
            }
            set
            {
                if (value <= 0)
                    espesor = 1;
                else
                    espesor = value;
            }
        }

        public int Area
        {
            get
            {
                return area;
            }
        }
        public int Volumen
        {
            get
            {
                return volumen;
            }
        }


        //Definiendo los constructores
        public Prisma()
        {
            //Datos necesarios
            String valor = "";

            //Pedimos los datos
            Console.Write("Dame el ancho: ");
            valor = Console.ReadLine();
            ancho = Convert.ToInt32(valor);

            Console.Write("Dame el alto: ");
            valor = Console.ReadLine();
            alto = Convert.ToInt32(valor);

            Console.Write("Dame el espesor: ");
            valor = Console.ReadLine();
            espesor = Convert.ToInt32(valor);
        }


        //Versión sobrecargada
        public Prisma(int zAncho, int Zalto, int Zespesor)
        {
            //Asignamos los valores
            ancho = zAncho;
            alto = Zalto;
            espesor = Zespesor;
        }

        //Definimos los metodos
        public void CalculaVolumen()
        {
            volumen = ancho * alto * espesor;
        }

        public void CalculaArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, espesor);
            a3 = 2 * CalcularRectangulo(alto, espesor);

            area = a1 + a2 + a3;

        }
        private int CalcularRectangulo(int a, int b)
        {
            return (a * b);
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Ancho = " + ancho.ToString() + " Alto = " + alto.ToString() + " Espesor = " + espesor.ToString() + " Area = " + area.ToString() + " Volumen = " + volumen.ToString();

            return mensaje;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("El área es: {0}, el volumen es: {1}", area, volumen);
        }

    }
}
