using State;

class Hambrienta : State
{
    public override void Comer()
    {
        base.CambiarState(Contento contento);
    }
    public override void juegue()
    {}
    public override void PuedeJugar()
    {}
}