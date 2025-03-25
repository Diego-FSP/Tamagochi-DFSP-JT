namespace State;
using Mascota;
class Hambrienta : State
{
    public override void Comer(Tamagotchi mascota)
    {
        mascota.CambiarState(new Contento());

    }
    public override void Jugar(Tamagotchi mascota)
    {} 
}