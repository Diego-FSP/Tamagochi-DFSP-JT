namespace Mascota;

class Tamagochi
{
    public byte felicidad;
    public State estado;

    public virtual Comer()
    {}
    public virtual Jugar()
    {}
    public virtual bool PuedeJugar()
    {}

    public CambiarState()
    {}

    public bool EstasFeliz()
    {}
}