namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // InformationBase aInformation= new InformationBase(); //We can not the new abstract classes

            InformationBase aInformation=new AInformation();
            InformationBase bInformation=new BInformation();
            InformationBase cInformation=new CInformation();

           
            aInformation.Process();
            aInformation.Save();

        }

        abstract class InformationBase
        {

           

            public InformationBase() {
              

        }

           



            public abstract void Process(); //include half operations it means. it didnt finish the operation

            public void Save()
            {
                Console.WriteLine("they saved"); //include finished operations
            }




        }


        class AInformation : InformationBase //it is working as ainterfaces 
        {
            public override void Process() //override we can update for everyeach class
            {
                Console.WriteLine("Ainformation");
            }
        }

        class BInformation : InformationBase
        {
            public override void Process()
            {
                Console.WriteLine("B information");
            }
        }

        class CInformation : InformationBase
        {
            public override void Process()
            {
                Console.WriteLine("C information");
            }
        }
    }
}