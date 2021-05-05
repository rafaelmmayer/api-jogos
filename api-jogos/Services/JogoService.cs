using api_jogos.Models;
using api_jogos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_jogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public Task AtualizarJogo(int id, Jogo jogo)
        {
            return _jogoRepository.AtualizarJogo(id, jogo);
        }

        public Task DeletarJogo(int id)
        {
            return _jogoRepository.DeletarJogo(id);
        }

        public Task<Jogo> InserirJogo(Jogo jogo)
        {
            return _jogoRepository.InserirJogo(jogo);
        }

        public Task<Jogo> ObterJogo(int id)
        {
            return _jogoRepository.ObterJogo(id);
        }

        public Task<List<Jogo>> ObterJogos()
        {
            return _jogoRepository.ObterJogos();
        }
    }
}
