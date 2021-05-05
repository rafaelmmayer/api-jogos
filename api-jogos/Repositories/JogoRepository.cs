using api_jogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_jogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private static List<Jogo> Jogos = new List<Jogo>()
        {
            new Jogo() {Id = 1, Nome = "Need For Speed", Preco = 150, Produtora = "EA"},
            new Jogo() {Id = 2, Nome = "Fifa", Preco = 102154123, Produtora = "EA"},
            new Jogo() {Id = 3, Nome = "Pokemon", Preco = 250, Produtora = "Nintendo"},
            new Jogo() {Id = 4, Nome = "Zelda", Preco = 30, Produtora = "Nintendo"},
        };

        public Task AtualizarJogo(int id, Jogo jogo)
        {
            Jogos.RemoveAt(id - 1);
            Jogos.Add(jogo);
            return Task.CompletedTask;
        }

        public Task DeletarJogo(int id)
        {
            Jogos.RemoveAt(id - 1);
            return Task.CompletedTask;
        }

        public Task<Jogo> InserirJogo(Jogo jogo)
        {
            Jogos.Add(jogo);
            return Task.FromResult(jogo);
        }

        public Task<Jogo> ObterJogo(int id)
        {
            return Task.FromResult(Jogos.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Jogo>> ObterJogos()
        {
            return Task.FromResult(Jogos);
        }
    }
}
