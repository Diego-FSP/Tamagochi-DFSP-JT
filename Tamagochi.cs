namespace Mascota;

class Tamagochi
{
    public byte felicidad=0;
    public State estado;

    public virtual void Comer()
    {}
    public virtual void Jugar()
    {}
    public virtual bool PuedeJugar()
    {}

    public void CambiarState(State nestado)
    {
        estado=nestado;
    }

    public bool EstasFeliz()
        bool feliz=true;
        if(felicidad<5)
        feliz=false;
        return feliz;
    }
}