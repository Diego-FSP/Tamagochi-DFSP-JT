namespace State;
class Contento : State
{
    byte jugo=0;
    public override void Comer(Tamagochi mascota)
    {
        if(base.felicidad<10)
        base.felicidad++;
    }
    public override void Jugar(Tamagochi mascota)
    {
        if(jugo<5)
        {
            base.felicidad+=2;
            jugo++;
        }
        else
        mascota.CambiarState(new Hambrienta);
    }
    public override void PuedeJugar()
    {

    }
}