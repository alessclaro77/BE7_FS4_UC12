using BE7_FS4_UC12.Interfaces;

namespace BE7_FS4_UC12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        

        public override float PagarImposto(float rendimento)
        {
            /*Escala:
            -ate 1500 (conciderando 1500) Reais - isento
            -de 1500 ate 3500 (conciderando 3500) Reais - 2% imposto
            -de 3500 ate 6000 (conciderando 6000) Reais - 3.5% imposto
            acima de 6000 - 5% imposto
            */
            if (rendimento <= 1500)
            {
                return 0;                
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento / 100) * 2;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return rendimento * 0.035f;
            }
            else{
                return (rendimento / 100) * 5;
            }            
        }

        public bool validarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;
            if(anos>= 18){
                return true;
            }                
            return false;     
        }
        
         public bool validarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string esta em formato valido
            if (DateTime.TryParse(dataNasc, out dataConvertida)){ //TryParse tenta converter e coloca na saida out
                //Console.WriteLine($"{dataConvertida}");
                DateTime datAtual= DateTime.Today;
                double anos = (datAtual - dataConvertida).TotalDays / 365;
                if(anos>= 18){
                    return true;
                }                
                return false; 
            }   
            return false;
               
        }
    }
}