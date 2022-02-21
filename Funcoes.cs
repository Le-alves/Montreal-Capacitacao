namespace AtivSem01
{
    class Funcoes
    {
        //Função parametro
        public int MaiorNumero (int a, int b, int c, int d)
        {
            int armzenamento1;
            int armzenamento2;
            int armzenamentoMaior;

            if (a > b){
                armzenamento1 = a;
            
            }else{
            
                armzenamento1 = b;
            }
            if (c > d) 
            {
                armzenamento2 = b;
            }
            else
            {
                armzenamento2 = d;
            }

            if (armzenamento1 > armzenamento2) 
            {
                armzenamento1 = armzenamentoMaior;
            }
            else
            {
                armzenamento2 = armzenamentoMaior;
            }            

            return armzenamentoMaior;
        }
    }
}