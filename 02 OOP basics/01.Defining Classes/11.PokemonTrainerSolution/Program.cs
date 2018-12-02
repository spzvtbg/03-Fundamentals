using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;

        var trainers = new List<Trainer>();

        while ((input = Console.ReadLine()).ToLower() != "tournament")
        {
            var parameters = input.SplitWithStringSplitOptions(" ");

            var trainerName = parameters[0];
            var pokemonName = parameters[1];
            var element = parameters[2];
            var health = parameters[3];

            var pokemon = new Pokemon(pokemonName, element, health);

            Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

            bool isNewTrainer = false;

            if (trainer == null)
            {
                isNewTrainer = true;
                trainer = new Trainer(trainerName);
            }

            trainer.AddNew(pokemon);

            if (isNewTrainer)
            {
                trainers.Add(trainer);
            }
        }

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            for (int count = 0; count < trainers.Count; count++)
            {
                if (trainers[count].Pokemons.Any(x => x.Element == input))
                {
                    trainers[count].Badges++;
                }
                else
                {
                    for (int index = 0; index < trainers[count].Pokemons.Count; index++)
                    {
                        trainers[count].Pokemons[index].Health -= 10;

                        if (trainers[count].Pokemons[index].Health <= 0)
                        {
                            trainers[count].Pokemons.Remove(trainers[count].Pokemons[index]);
                        }
                    }
                }
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, trainers.OrderByDescending(x => x.Badges)));
    }
}
