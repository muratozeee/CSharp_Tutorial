

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
     interface IPersonManager
    {
        public string TcId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirhOfDate { get; set; }

        public string Status { get; set; }
        void Login();
        void Update();
        void Delete();
    }
}
