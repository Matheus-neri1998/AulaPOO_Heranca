using System;
using AulaPOO_Heranca.Classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {   // Instanciando a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();
            // Console.WriteLine("Qual o se tipo de documento? (CPF/CNPJ)");
            // string resposta;

            


            // Atribuimos um cpf ao objeto
            pf.cpf = "367.739.158-05";

            pf.nome = "Matheus";

            // Chamamos nosso método de saudação dentro de um Console.Writeline
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            // Chamamos nosso método de validação da subclasse
            Console.WriteLine( pf.ValidarCPF(pf.cpf) );

            PessoaJuridica pj = new PessoaJuridica();

            pj.cnpj = "12.456.789/1234-10";

            pj.nome = "Mathias";

            Console.WriteLine( pj.DarBoasVindas(pj.nome));

            Console.WriteLine( pj.ValidarCNPJ(pj.cnpj));
        } // fim de Main
    }
}
