namespace prj_contas
{
    public class Poupanca: Conta
    {
        public int aniversario {get; private set; }

        public Poupanca(string argNumero, string argAgencia, int argAniversario) : base(argNumero, argAgencia)
        {
            setAniversario(argAniversario);
        }

        public void setAniversario(int argAniversario){
            this.aniversario = argAniversario;
        }

        public override bool Sacar(double argValor)
        {
            if (argValor <= base.saldo)
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
            texto += "\nAniversário: " + this.aniversario;
            return texto;
        }


//        public override string /*Imprimir*/ToString(){

//          string texto;
//            texto = base./*Imprimir*/ToString();
//            texto += "\nAniversário: " + this.Aniversario;
//            return texto;
//        }
    }
}