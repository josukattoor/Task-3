using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    // Create abstract class UserError
    public abstract class UserError
    {
        // Create abstract method UEMessage()
        public abstract string UEMessage();
    }

    // Create regular class NumericInputError inherited from UserError
    public class NumericInputError : UserError
    {
        // Override UEMessage() with NumericInputError
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    // Create regular class TextInputError that inherits from UserError
    public class TextInputError : UserError
    {
        // Override UEMessage() for TextInputError
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // Create three custom classes with custom UEMessage() implementations
    public class CustomError1 : UserError
    {
        public override string UEMessage()
        {
            return "This is a message from Custom Error 1.";
        }
    }

    public class CustomError2 : UserError
    {
        public override string UEMessage()
        {
            return "This is a message from Custom Error 2.";
        }
    }

    public class CustomError3 : UserError
    {
        public override string UEMessage()
        {
            return "This is a message from Custom Error 3.";
        }
    }
}
