using Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert pokemon name: ");
            var pokName = Console.ReadLine();
            Console.WriteLine("Insert trainer name: ");
            var trainer =  Console.ReadLine();

            var pokManager = new PokemonManager();
            pokManager.RegisterPokemon(pokName, trainer);

            

           
        }
    }
}
