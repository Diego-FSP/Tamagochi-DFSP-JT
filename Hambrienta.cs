using State;

class Hambrienta : State
{
    public override void Comer(Tamagotchi mascota)
    {
        mascota.CambiarState(new Contenta);
    }
    public override void juegue()
    {}
    public override void PuedeJugar()
    {}
}