namespace Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multipliar(int n1, int n2);
        int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}