using System;
using System.IO;
using ProjetoPOO.Helper;
using ProjetoPOO.Interfaces;
using ProjetoPOO.Models;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHelper helper = new FileHelper();

            var caminho = "C:\\Workspace\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho,"PastaTeste1");
            var caminhoArquivo = Path.Combine(caminho, "arquivoTesteStream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivoTeste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivoTesteBkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "arquivoTesteStream.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            
            //helper.ListarDiretorios("C:\\Workspace\\TrabalhandoComArquivos");
            //helper.ListarArquivosDiretorios(caminho);
            //System.Console.WriteLine($"Criando Diretório: {caminhoPathCombine}");
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo!!!");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Multiplicar(12, 21));

            // Computador comp = new Computador();            
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10, 10));
            // System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10, 10)}");
            
            // Aluno a2 = new Aluno();
            // a2.Nome = "Loba";
            // a2.Idade = 22;
            // a2.Documento = "qwert";
            // a2.Nota = 11;
            // a2.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = " LILA";
            // p2.Idade = 45;
            // p2.Documento = "67890";
            // p2.Salario = 999;
            // p2.Apresentar();

            // Aluno a1 = new Aluno();
            // a1.Nome = "Jota";
            // a1.Idade = 23;
            // a1.Documento = "123456";
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Poney";
            // p1.Idade = 45;
            // p1.Documento = "654321";
            // p1.Apresentar();

            // Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(40, 40);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bola";
            // p1.Idade = 23;
            // p1.Apresentar();
        }
    }
}
