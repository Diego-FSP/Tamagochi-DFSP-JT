using Mascota;
namespace State;

abstract class State
{
    private string nombre;

    public virtual void Comer(Tamagotchi mascota)
    {}
    public virtual void Jugar(Tamagotchi mascota)
    {}
}