namespace AtivSem01
{
    class Program
    {
        static void Main (string[] args)
        {
            //Entrada de dados para maior número
            Funcao funcoes = new Funcao();
            funcoes.Num1 = 1;
            funcoes.Num2 = 1;
            funcoes.Num3 = 1;
            funcoes.Num4 = 1;

            int resultado = funcoes.SomaNumeros;
            Console.Write(resultado);
            Console.ReadKey ();

        }
    }
}

