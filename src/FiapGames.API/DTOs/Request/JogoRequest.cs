using FiapGames.API.Entidades;

namespace FiapGames.API.DTOs.Request;

public record JogoRequest(string Titulo, decimal Preco)
{
    public Jogo ConverterParaEntidade()
    {
        return new Jogo(Titulo, Preco);
    }
}
