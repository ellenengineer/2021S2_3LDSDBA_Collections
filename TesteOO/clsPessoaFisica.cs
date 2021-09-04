using System;


namespace TesteOO
{
    public class clsPessoaFisica: clsPessoa
    {
        string _rg;
        public string CPF { get; set; }

        public string RG
        { 
            get { return _rg; }
            set { this._rg = value; }
        }

        public clsPessoaFisica()
        {
        }

        //ou

        public clsPessoaFisica(string _nome, DateTime _dtNasc) => (Nome, DataNascimentoFundacao) = (_nome, _dtNasc);


     
       

    }
}
