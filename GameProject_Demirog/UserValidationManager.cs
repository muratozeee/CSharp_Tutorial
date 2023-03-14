using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{

    //We used the abstract
    //now this class is Concrete to use methods...Validate..!
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer) //we used the bool
        {

            if (gamer.BirthYear==1995 && gamer.FirstName=="Murat" 
                && gamer.LastName=="OZ" && gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
