using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataManager
    {
        public void AddPokemon(Pokemon pokemon) {

            Datastore.Pokemons.Add(pokemon);
        }

        public List<Pokemon> GetPokemons() {

            return Datastore.Pokemons;
        }
    }

    
}
