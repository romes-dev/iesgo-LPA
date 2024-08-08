// Programa em C# em que o usuário insere o nome e a data de nascimento e o sistema retorna o seu nome e idade.
using System;
using System.Text;

class Programa
{
    static void Main()
    {
        //Usar UTF-8 no Console
        Console.OutputEncoding = Encoding.UTF8;
        
        //Solicitar ao usuário o seu nome
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();
        
        //Solicitar ao usuário a data de nascimento
        Console.Write("Agora, insira sua data de nascimento (DD/MM/AAAA): ");
        string dataNascimentoInput = Console.ReadLine();
        
        //Converter a String dataNascimento para DataType (DateTime)
        DateTime dataNascimento;
        if (DateTime.TryParseExact(dataNascimentoInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            //Calular a idade do usuário
            int idade = CalcularIdade(dataNascimento);
            
            //Responder o usuário no Console
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos. ");
        }
        else
        {
            //Mensagem de erro
            Console.WriteLine("Insira uma data de nascimento válida (dd/mm/aaaa). ");
        }
        
        static int CalcularIdade(DateTime dataNascimento)
        {
            //DateTime de hoje
            DateTime hoje = DateTime.Today;
            
            //Calcular a idade
            int idade = hoje.Year - dataNascimento.Year;
            
            //ajustar a idade caso não tenha completado aniversário
            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            
            return idade;
            
        }
        
        
        
        
    }
}
