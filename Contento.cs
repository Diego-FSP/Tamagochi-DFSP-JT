using State;

class Contento : State
{
    byte jugo=0;
    public override void Comer()
    {
        if(base.felicidad<10)
        base.felicidad++;
    }
    public override void juegue(Tamagochi mascota)
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