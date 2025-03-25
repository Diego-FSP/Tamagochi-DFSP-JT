namespace State;
using Mascota;
class Contento : State
{
    byte jugo=0;
    public Contento()
    {
        base.nombre="Contento";
    }
    public override void Comer(Tamagotchi mascota)
    {
        if(mascota.felicidad<10)
        mascota.felicidad++;
    }
    public override void Jugar(Tamagotchi mascota)
    {
        if(jugo<5)
        {
            mascota.felicidad+=2;
            jugo++;
        }
        else
        mascota.CambiarState(new Hambrienta);
    }
}