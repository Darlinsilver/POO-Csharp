namespace ProjetoPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor com salário {Salario}");
        }
    }
}