using Mascota;
namespace State;

abstract class State: Tamagochi 
{
    private string nombre;
    public override void State()
    {}
    public override void Comer()
    {}
    public override void juegue()
    {}
    public override bool PuedeJugar()
    {}
}