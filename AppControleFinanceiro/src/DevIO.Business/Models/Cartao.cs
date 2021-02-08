using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public string Numero { get; set; }
        public Double Limite { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public virtual ICollection<Despesa> Despesas  { get; set; }
    }
}
