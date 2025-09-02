﻿using FiapGames.API.Entidades;

namespace FiapGames.API.Interfaces
{
    public interface IJogoServico
    {
        void Atualizar(Jogo jogoOriginal, Jogo jogoAlteracoes);
        void AtualizarPreco(Jogo jogoOriginal, decimal preco);
        int Criar(Jogo jogo);
        Jogo? ObterPorId(int id);
        List<Jogo> ObterJogos(string titulo);
        void Remover(int id);
    }
}