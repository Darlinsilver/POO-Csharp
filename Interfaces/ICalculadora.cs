namespace ProjetoPOO.Interfaces
{
    public interface ICalculadora
    {
        //Assinatura do método
         int Somar(int num1, int num2);
         int Subtrair(int num1, int num2);
         //Método implementado
         int Multiplicar(int num1, int num2)
         {
             return num1 * num2;
         }
         int Dividir(int num1, int num2)
         {
             return num1 / num2;
         }
    }
}