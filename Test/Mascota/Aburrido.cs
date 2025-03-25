namespace State;
using Mascota;
class Aburrido: State
{
    DateTime inicio;
    short minutosAburrida;
    short umbralComida;

    public Aburrido()
    {
        inicio = DateTime.Now();
    }

    public override bool PuedeJugar()
    {}
    public override void Comer(Tamagotchi mascota)
    {
        Tiempo();
        if(minutosAburrida>umbralComida)
        mascota.CambiarState(new Contenta);
    }
    public override void Jugar(Tamagochi mascota)
    {}

    private void Tiempo()
    {
        DateTime ahora = DateTime.Now - inicio;
        minutosAburrida = (ahora.Minute) + (ahora.Hour*59) + (ahora.Day*1416);
    }
}