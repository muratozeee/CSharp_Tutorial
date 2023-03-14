using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{

    //What is the MicroService? it means,I will use the service from outside..!
    class GamerManager : IGamerService
    {

        //Also ı want to use validation service to validate them then we have to use the construct... we can not use the new

        //Write the name of class and write(_+representative name then tap) then click the bulb to create (the Generate contstract Service)

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        //This one is not concrete... it is Abstract...!



        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer was Registired..! Successfully..!");

                Console.WriteLine("Gamer Id= "+gamer.Id);
                Console.WriteLine("Gamer FirstName= "+gamer.FirstName);
                Console.WriteLine("Gamer LastName= "+gamer.LastName);
                Console.WriteLine("Gamer İdendtity Number= "+gamer.IdentityNumber);
                Console.WriteLine("Gamer Birth Of Year= "+gamer.BirthYear);
                Console.WriteLine("---------");

            }
            else
            {
                Console.WriteLine("Games was not Registired..! UnSuccessfully..!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer was Deleted..!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer was Updated..!");
        }
    }
}
