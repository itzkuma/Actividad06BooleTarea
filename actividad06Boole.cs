using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad06Boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los valores de a, b, blancos, anulados, n , p");
            int votospartido1 = int.Parse(Console.ReadLine());
            int votospartido2 = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int numerototaledades = int.Parse(Console.ReadLine());
            int porcentajemayoredad = int.Parse(Console.ReadLine());
            int mayoredad = numerototaledades * porcentajemayoredad;
            int votostotales = (votospartido1 + votospartido2 + blancos + anulados);
            int abstencion = votostotales - mayoredad;

            bool a = (votostotales > mayoredad); 
            //total de votos superior a la poblacion
            bool b = (votospartido1-votospartido2) < 0.10 * (votostotales);
            //diferencia entre 1 y 2 es menor al 10% de los votos totales
            bool c = (votostotales) < 0.30 * (mayoredad);
            //el número de votantes es inferior al 30 % de la población
            bool d = (votospartido1 > votospartido2);
            bool e = (votospartido1 < votospartido2);
            if (((a || b) && (c)))
            {
                Console.WriteLine("las elecciones deben ser ejecutadas nuevamente");
                
            }

            else if  (d)
            {
                
                Console.WriteLine("ganador elecciones: partido 1");

            }

            else if (e)
            {

                Console.WriteLine("ganador elecciones: partido 2");

            }




        }
    }
}
