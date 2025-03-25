using System;
using Mascota;
using State;

public class Program
{
    public static void Main(string[] arg)
    {
        Tamagotchi mascota=new Tamagotchi();
        bool salir=false;
        byte rta;
        while (salir==false)
        {
            Console.WriteLine("Estado= "+mascota.Estado.nombre+"|Felicidad= "+mascota.felicidad);
            Console.WriteLine("que quieres hacer");
            Console.WriteLine("1.-Comer");
            Console.WriteLine("2.-Jugar");
            rta= byte.Parse(Console.ReadLine());
            switch(rta)
            {
                case 1:
                mascota.Comer();
                break;
                case 2:
                mascota.Jugar();
                break;
            }
        }
    }
}