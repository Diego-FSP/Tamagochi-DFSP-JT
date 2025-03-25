using Mascota;
namespace State;

abstract class State
{
    public string nombre="";

    public virtual void Comer(Tamagotchi mascota)
    {}
    public virtual void Jugar(Tamagotchi mascota)
    {}
}