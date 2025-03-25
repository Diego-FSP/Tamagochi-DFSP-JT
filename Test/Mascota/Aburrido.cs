namespace State;
using Mascota;
class Aburrido: State
{
    DateTime inicio;
    int minutosAburrida;
    int umbralComida=80;

    public Aburrido()
    {
        base.nombre="Aburrido";
        inicio = DateTime.Now;
    }

    public override void Comer(Tamagotchi mascota)
    {
        Tiempo();
        if(minutosAburrida>umbralComida)
        mascota.CambiarState(new Contento());
    }
    public override void Jugar(Tamagotchi mascota)
    {}

    private void Tiempo()
    {
        DateTime ahora = DateTime.Now;
        System.TimeSpan resta = inicio - ahora;
        minutosAburrida = (resta.Minutes) + (resta.Hours*60) + (resta.Days*1416);
    }
}