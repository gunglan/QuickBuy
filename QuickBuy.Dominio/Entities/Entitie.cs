using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entitie
    {
        public List<string> _mensagemValidacao { get; set; }
        protected List<string> mensagemValidacao 
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); } 
        }
        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool itsValid
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
