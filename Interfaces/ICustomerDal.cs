using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
        internal interface ICustomerDal //Dal=Data Access Layer.
        {
            void Add();
            void Update();
            void Delete();

        }

        class MySqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {

                Console.WriteLine("MySql was Added..!");
            }

            public void Delete()
            {
                Console.WriteLine("MySql was Deleted..!");
            }

            public void Update()
            {
                Console.WriteLine("MySql was Updated..!");
            }
        }

            class SqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {

                Console.WriteLine("Sql was Added..!");
            }

            public void Delete()
            {
                Console.WriteLine("Sql was Deleted..!");
            }

            public void Update()
            {
                Console.WriteLine("Sql was Updated..!");
            }
        }
        class OracleServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle was Added..!");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle was Delet..!");
            }

            public void Update()
            {
                Console.WriteLine("Oracle was Update..!");
            }


            }
            class CustomerManager
            {

                public void Add(ICustomerDal customerDal)
                {

                    customerDal.Add();
                    customerDal.Delete();
                    customerDal.Update();


                }
            }

    }

