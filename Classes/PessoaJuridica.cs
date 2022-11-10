using BE7_FS4_UC12.Interfaces;
using System.Text.RegularExpressions;

namespace BE7_FS4_UC12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";


        public override float PagarImposto(float rendimento)
        {
             /*Escala:
            -ate 1500 (conciderando 1500) Reais - - 3% imposto
            -de 1500 ate 3500 (conciderando 3500) Reais - 5% imposto
            -de 3500 ate 6000 (conciderando 6000) Reais - 7% imposto
            acima de 6000 - 9% imposto
            */
            if (rendimento <= 1500)
            {
                return (rendimento / 100) * 3;                
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento / 100) * 5;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return (rendimento/100) * 7;
            }
            else{
                return (rendimento / 100) * 9;
            }            
        }

        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001")//vai iniciar no caractere 11 e pegar os proximos 4 
                    {
                        return true;        
                    }
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001")// vai iniciar no caractere 8 e pegar os proximos 4
                    {
                        return true;
                    }                           
                }          
            } 
        return false;          
        }
        public void Inserir(PessoaJuridica pj)
        {
            verificarPastaArquivo(caminho);
            string[] pjString = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};
            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> Ler() 
        {
          List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
          
          string[] linhas = File.ReadAllLines(caminho);
          
          foreach(string cadaLinha in linhas)
          {
            string[] atributos = cadaLinha.Split(",");
            
            PessoaJuridica cadaPj = new PessoaJuridica();
            
            cadaPj.nome = atributos[0];
            cadaPj.cnpj = atributos[1];
            cadaPj.razaoSocial = atributos[2];

            listaPj.Add(cadaPj);
          } 
          return listaPj;   
        }
    }
}