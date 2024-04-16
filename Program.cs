using System.Linq;
internal class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");


        Menu();

        static void Menu()
        {
            Console.Write("Digite o CPF:");

            var cpf = Console.ReadLine();
        
            Validacao1(cpf);
       
            validacao2(cpf); 
        }


        static void Validacao1(string? cpf)
        {
            
            if (cpf == null)
                Validacao1(cpf);

            var tamanho = cpf?.Length;

            if (tamanho == 11)
            {
                Console.WriteLine("Este CPF esta correto? " + cpf + " " + 1 +" = S ou " + 2 +" = N");

                    short s = short.Parse(Console.ReadLine()!);
                switch (s)
                {
                    case 1: Console.WriteLine("Aprovado na primeira validação"); break;
                
                    default: Menu(); 
                    break;
                }
            }
            else
            {
                Console.WriteLine(cpf + " tem " + cpf?.Length + " digitos, tem que ter 11 digito");
            }
        }

        static void validacao2(string? cpf)
        {
            char[] arr = cpf!.ToCharArray();

            int a = int.Parse(arr[0].ToString());
            int b = int.Parse(arr[1].ToString());
            int c = int.Parse(arr[2].ToString());
            int d = int.Parse(arr[3].ToString());
            int e = int.Parse(arr[4].ToString());
            int f = int.Parse(arr[5].ToString());
            int g = int.Parse(arr[6].ToString());
            int h = int.Parse(arr[7].ToString());
            int i = int.Parse(arr[8].ToString());
            int j = int.Parse(arr[9].ToString());
            int k = int.Parse(arr[10].ToString());

            var soma = a + b + c + d + e + f + g + h + i + j + k;

            char[] sm = soma.ToString().ToCharArray();
            
            var sm1 = sm[0];
            var sm2 = sm[1];

            if (sm1 == sm2)
                Console.WriteLine("Aprovado na segunda validação");
            else 
                Console.WriteLine("Reporvado na segunda validação");

            
        }
    }
}
