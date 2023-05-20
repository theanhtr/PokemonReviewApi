using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int pokeId);
        Pokemon GetPokemon(string pokeName);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
    }
}
