namespace Mascota;
using State;
class Tamagotchi
{
    Tamagotchi Mascota;
    public byte felicidad=0;
    public State Estado;

    public void Comer()
    {
        Estado.Comer(Mascota);
    }
    public void Jugar()
    {
        Estado.Jugar(Mascota);
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