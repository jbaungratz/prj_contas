namespace prj_contas
{
    public class Corrente: Conta
    {
        public double limite {get; private set;}

        public Corrente(string argNumero, string argAgencia, double argLimite) : base(argNumero, argAgencia)
        {
            setLimite(argLimite);            
        }


        public void setLimite(double argLimite){
            if (argLimite > 100) {

                this.limite = argLimite; 
            }
            else
                this.limite = 0;
        }

        public override bool Sacar(double argValor)
        {
            if ((argValor <= (base.saldo + this.limite)))
            {
                base.setSaldo(base.saldo - argValor);
                return true;
            }
            else{
                return false;
            }
        }

        public string ToString(){
            string texto = base.ToString();
            texto += "\nLimite: " + this.limite;
            return texto;
        }




        //        public override string /*Imprimir*/toString(){

        //            string texto;
        //            texto = base./*Imprimir*/toString();
        //            texto += "\nLimite: " + this.Limite;
        //            return texto;
        //        } 
        /*
                public override void Imprimir(string age, string num, double sal){
                    Console.WriteLine("Agência: " + ag + "\nConta: " + num + "\nSaldo: " + sal + "\nLimite: " + Limite);

                } 
                */
    }
}