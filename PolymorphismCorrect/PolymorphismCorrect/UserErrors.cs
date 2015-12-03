using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCorrect
{
    #region Assignment1
    public abstract class UserErrors
    {
        #region Assignment2
        public abstract string UEMessage();
        #endregion
    }
    #endregion
    #region Assignment3
    public class NumericInputError : UserErrors
    {
        #region Assignment4
        public override string UEMessage()
        {
            return  "You tried to use a numeric input in a text only field. This fired an error!";
        }
        #endregion
    }
    #endregion
    #region Assignment5
    public class TextInputError : UserErrors
    {
        #region Assignment6
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
        #endregion
    }
    #endregion
    #region Assignment9
    public class OutOfBoundsError : UserErrors
    {

        public override string UEMessage()
        {
            return "You tried to enter an input out of the given bounds. This fired an error!";
        }

    }
    public class WhitespaceError : UserErrors
    {

        public override string UEMessage()
        {
            return "You started your input with whitespace, this is now allowed!";
        }

    }    public class SpecialCharacterError : UserErrors
    {

        public override string UEMessage()
        {
            return "You tried to use a Special Character that isn't allowed in your input. This fired an Error!";
        }

    }
    #endregion


}
