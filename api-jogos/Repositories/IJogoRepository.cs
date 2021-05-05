using api_jogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_jogos.Repositories
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> ObterJogos();
        Task<Jogo> ObterJogo(int id);
        Task<Jogo> InserirJogo(Jogo jogo);
        Task AtualizarJogo(int id, Jogo jogo);
        Task DeletarJogo(int id);
    }
}
