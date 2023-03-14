using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
    class GamerManager : IGamerService
    {

        ValidationManager _validationManager;

        public GamerManager(ValidationManager validationManager)
        {
            _validationManager = validationManager;
        }

        public void Add(Gamer gamer)
        {

            if (_validationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer was Registired...! Succesfully..!");

                Console.WriteLine($"Gamer Name={gamer.FirtsName} {gamer.LastName} ");

            }
            else
            {
                Console.WriteLine("UnSuccesfully..! Can you try again...!");
            }


            

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer was Deleted..! Successfully..!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer was Updated..! Succesfully..!");

        }
    }
}
