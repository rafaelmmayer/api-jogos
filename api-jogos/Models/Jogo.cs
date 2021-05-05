using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_jogos.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
    }
}
