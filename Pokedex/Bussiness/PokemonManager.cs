using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Bussiness
{
    public class PokemonManager
    {
        public void RegisterPokemon(string name, string trainer)
        {
            var pok = new Pokemon(name, trainer);
            var datamanager = new DataManager();
            datamanager.AddPokemon(pok);

        }

        public List<Pokemon> GetRegisteredPokemon()
        {
            var datamanager = new DataManager();
            var pokemons = datamanager.GetPokemons();
            return pokemons;
        }
    }
}
