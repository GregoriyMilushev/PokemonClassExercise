using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badgets = 0;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public string Name { get => name; set => name = value; }

        public int Badgets { get => badgets; set => badgets = value; }

        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Pokemons.Add(pokemon);
        }

        public void ContainsPokemon(string element)
        {
            bool isContained = false;
            foreach (var pokemon in Pokemons)
            {
                if (pokemon.Element == element)
                {
                    isContained = true;
                    this.Badgets += 1;
                    break;
                }
            }

            if (isContained == false)
            {
                var pokemonsDeath = new List<Pokemon>();
                foreach (var pokemon in Pokemons)
                {
                    pokemon.Health -= 10;
                    if (pokemon.Health <= 0)
                    {
                        pokemonsDeath.Add(pokemon);
                    }
                }

                foreach (var pokemon in pokemonsDeath)
                {
                    Pokemons.Remove(pokemon);
                }
            }
        }
    }
}
