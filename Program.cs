internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Digite o CPF:");

        string? cpf = Console.ReadLine();
        
        ValidarQuantidade(cpf);



        static void ValidarQuantidade(string? cpf)
        {
            
            if (cpf == null)
                Console.WriteLine("Digite um CPF");

            var tamanho = cpf?.Length;

            if (tamanho == 11)
                Console.WriteLine("Este CPF esta correto? " + cpf);

            else
            {
                Console.WriteLine(cpf + " tem " + cpf?.Length + " digitos, tem que ter 11 digito");
            }
        }

        static void PrimeiroMetodo(string? cpf)
        {
            
        }
    }
}
