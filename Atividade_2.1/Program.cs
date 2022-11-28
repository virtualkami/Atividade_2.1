namespace Atividade_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criação e recebimento da string numeros
            string numeros = @"Um Dois Três Quatro";
            // criação e recebimento da string letras
            string letras = @"A B C D";
            // bloco using onde esquerda recebe números e direita recebe letras
            using(StringReader esquerda=new StringReader(numeros),direita=new StringReader(letras))
            {
                // criação da string item
                string item;
                // bloco do while
                do
                {
                    //item recebe esquerda
                    item = esquerda.ReadLine();
                    // mostra item
                    Console.WriteLine(item);
                    // item recebe direita
                    item = direita.ReadLine();
                    // mostra item
                    Console.WriteLine(item);
                    // para a repetição quando item for nulo
                } while (item != null);
            }
        }
    }
}