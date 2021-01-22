using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryOfPokemonTrainers = new Dictionary<string, Trainer>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }
                var info = input.Split();
                var trainerName = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                var trainer = new Trainer(trainerName, pokemon);

                if (!dictionaryOfPokemonTrainers.ContainsKey(trainerName))
                {
                    dictionaryOfPokemonTrainers.Add(trainerName, trainer);
                }
                else
                {
                    dictionaryOfPokemonTrainers[trainerName].Pokemons.Add(pokemon);
                }
            }

            while (true)
            {
                var element = Console.ReadLine();
                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in dictionaryOfPokemonTrainers)
                {
                    trainer.Value.ContainsPokemon(element);
                }
            }

            foreach (var (name,trainer) in dictionaryOfPokemonTrainers
                .OrderByDescending(x => x.Value.Badgets))
            {
                Console.WriteLine($"{name} {trainer.Badgets} {trainer.Pokemons.Count}");Q
            }
        }
    }
}
