using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCorrect
{
    class Program
    {
        //For assignment 1-6 see UserErrors.cs
        static void Main(string[] args)
        {
            #region Assignment 7,10
            List<UserErrors> UEList = new List<UserErrors> { new NumericInputError(), new TextInputError(), new OutOfBoundsError(), new SpecialCharacterError(), new WhitespaceError() };
            #endregion
            #region Assignment 8,10
            foreach (UserErrors UE in UEList)
            {
                Console.WriteLine(UE.UEMessage());
            }
            Console.ReadKey();
            #endregion
            #region Assignment11&12
            //Polymorphism is important to create more modular, easily understood and Object Oriented Programs.
            //Polymorphism allows you to use less code for more functionality. And requires you to structure the code modularly.
            //If you change any of the errors listed above for another error it will work just as fine.
            #endregion
        }
    }
}
