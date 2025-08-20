namespace Atividade_de_portifolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.WriteLine("Digite o nome1 ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome2");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o nome3");
            nome3 = Console.ReadLine();

            Console.WriteLine("Digite o nome4");
            nome4 = Console.ReadLine();
            //mecanismo para inverter os nomes
            auxiliar = nome1;
            nome1 = nome4;

            nome4 = auxiliar;

            auxiliar = nome2;
            nome2 = nome3;

            nome3 = auxiliar;
            Console.WriteLine("Nome inseridos na sequência invertida: ");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey();//Final do programa 


        }
    }
}
