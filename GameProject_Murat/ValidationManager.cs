using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id ==1 && gamer.FirtsName=="Murat" && gamer.LastName=="OZ" && gamer.TcId==123456789 &&gamer.DateOfYear==1995)
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
