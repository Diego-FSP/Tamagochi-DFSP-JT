namespace Mascota;

class Tamagochi
{
    public byte felicidad;
    public State estado;

    public virtual void Comer()
    {}
    public virtual void Jugar()
    {}
    public virtual bool PuedeJugar()
    {}

    public void CambiarState()
    {}

    public bool EstasFeliz()
    {}
}