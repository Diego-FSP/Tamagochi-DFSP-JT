using Mascota;
namespace State;

abstract class State: Tamagotchi 
{
    private string nombre;

    public override void State()
    {}
    public override void Comer(Tamagotchi mascota)
    {}
    public override void juegue()
    {}
    public override bool PuedeJugar()
    {}
}