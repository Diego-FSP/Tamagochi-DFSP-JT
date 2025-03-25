namespace State;
using Mascota;
class Aburrido: State
{
    DateTime inicio;
    int minutosAburrida;
    int umbralComida=1;

    public Aburrido()
    {
        base.nombre="Aburrido";
        inicio = DateTime.Now;
    }

    public override void Comer(Tamagotchi mascota)
    {
        Tiempo();
        if(minutosAburrida>umbralComida)
        {
            if(mascota.felicidad<6)
            mascota.felicidad=6;
            mascota.CambiarState(new Contento());
        }
    }
    public override void Jugar(Tamagotchi mascota)
    {
        if(mascota.felicidad<6)
        mascota.felicidad=6;
        mascota.CambiarState(new Contento());
    }

    private void Tiempo()
    {
        DateTime ahora = DateTime.Now;
        System.TimeSpan resta = ahora - inicio;
        minutosAburrida = (resta.Minutes) + (resta.Hours*60) + (resta.Days*1416);
    }
}