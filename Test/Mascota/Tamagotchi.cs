namespace Mascota;
using State;
class Tamagotchi
{
    public byte felicidad=0;
    public State Estado;

    public void Comer()
    {
        Estado.Comer(this);
    }
    public void Jugar()
    {
        Estado.Jugar(this);
    }
    public bool PuedeJugar()
    {
        bool Si= true;
        if(felicidad<2)
        Si=false;
        return Si;
    }

    public void CambiarState(State nestado)
    {
        Estado=nestado;
    }

    public bool EstasFeliz()
    {
        bool feliz=true;
        if(felicidad<5)
        feliz=false;
        return feliz;
    }
}