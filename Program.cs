using System.Globalization;

namespace SistemaDeNotasEstudantil
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno: ");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: {0}", al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (al.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}