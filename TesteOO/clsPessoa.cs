using System;


namespace TesteOO
{
    public abstract class clsPessoa 
    {

        public string Nome { get; set; }

        protected DateTime _dataNascimento;
        public DateTime DataNascimentoFundacao { get; set; }

        public clsPessoa(DateTime _dtNasc)
        {
            this.DataNascimentoFundacao = _dtNasc;
        }

        public clsPessoa() => (DataNascimentoFundacao) = (_dataNascimento);

    }
}
