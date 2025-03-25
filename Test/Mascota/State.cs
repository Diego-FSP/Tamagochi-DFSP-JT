using Mascota;
namespace State;

abstract class State
{
    public required string nombre;

    public virtual void Comer(Tamagotchi mascota)
    {}
    public virtual void Jugar(Tamagotchi mascota)
    {}
}