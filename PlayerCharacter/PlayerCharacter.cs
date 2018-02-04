using System;
using System.Collections.Generic;

namespace PlayerCharacter
{
    public class PlayerCharacter
    {

        public PlayerCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapons();
        }


        public int Health { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }

        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }


        public void Sleep()
        {
            var rnd = new Random();

            var healthIncrease = rnd.Next(1, 101);

            Health += healthIncrease;
        }

        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }

        private string GenerateName()
        {

            var name = new[]
            {
                "David",
                "Joao",
                "Furtas",
                "Carlon",
                "Jakim"
            };


            return name[new Random().Next(0, name.Length)];
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>()
            {
                "Short sword",
                "Short bow",
                "Long bow"


               // "staff of wander"

                //,
                //"Long bow"
            };
        }

    }
}
