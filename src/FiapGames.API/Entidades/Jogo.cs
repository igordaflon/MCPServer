using FiapGames.API.Entidades.Base;

namespace FiapGames.API.Entidades;

public class Jogo : Entity
{
    public string Titulo { get; private set; }
    public decimal Preco { get; private set; }

    public Jogo(string titulo, decimal preco)
    {
        Titulo = titulo;
        Preco = preco;
    }
}
