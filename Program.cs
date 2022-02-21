namespace AtivSem01
{
    class Program
    {
        static void Main (string[] args)
        {
            //Entrada de dados para maior número
            Funcao funcoes = new Funcao();
            

            int resultado = funcoes.SomaNumeros();
            Console.Write(resultado);
            Console.ReadKey ();

        }
    }
}

