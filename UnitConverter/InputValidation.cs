using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class InputValidation
    {
        public delegate void ActionOnError(string errorMsg);

        private string inputValue;
        private ActionOnError actionOnError;
        public string ErrorMessage { get; private set; }

        public InputValidation(string inputValue, ActionOnError actionOnError)
        {
            this.inputValue = inputValue;
            this.actionOnError = actionOnError;
        }

        public bool ValidateInput()
        {
            if (inputValue.Equals(String.Empty))
            {
                ErrorMessage = "No input value given";
                actionOnError(ErrorMessage);
                return false;
            }

            if (!double.TryParse(inputValue, out double test))
            {
                ErrorMessage = "Not a valid value was given! Please give a numeric input!";
                actionOnError(ErrorMessage);
                return false;
            }

            return true;
        }


    }
}
