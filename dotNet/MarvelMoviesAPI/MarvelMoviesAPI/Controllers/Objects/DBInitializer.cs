﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelMoviesAPI.Controllers.Objects
{
    public class DBInitializer
    {
        public static void Initialize(MCUContext context)
        {
            context.Database.EnsureCreated();
 
            if (!context.MarvelMovies.Any())
            {
                var heroes = new Hero[]
                {
                    new Hero()
                        {
                            Name = "Tony Stark",
                            HeroName = "Iron Man",
                            Actor = "Robert Downey Jr.",
                            //FeaturedMovies = context.MarvelMovies.Where(m => m.Hero.Name == "Tony Stark").ToList() //hero.id
                        }
                };
                foreach (Hero h in heroes)
                {
                    context.Heroes.Add(h);
                }
                
                var villains = new Villain[]
                {
                     new Villain()
                     {
                         Name = "Obadiah Stane",
                         Actor = "Jeff Bridges",
                     },
                    new Villain()
                    {
                        Name = "Ivan Vanko",
                        Actor = "Mickey Rourke",
                    }
                };
                foreach (Villain v in villains)
                {
                    context.Villains.Add(v);
                }

                var mv = new Movie()
                {
                    Title = "Iron Man",
                    ReleaseYear = 2008,
                    Director = "Jon Favreau",
                    IMDBScore = 7.9f,
                    Hero = heroes[0],
                    Villain = villains[0]
                };
                context.MarvelMovies.Add(mv);
                mv = new Movie()
                {
                    Title = "Iron Man 2",
                    ReleaseYear = 2010,
                    Director = "Jon Favreau",
                    IMDBScore = 7.0f,
                    Hero = heroes[0],
                    Villain = villains[1]
                };
                context.MarvelMovies.Add(mv);
                context.SaveChanges();
            }
        }
    }
}