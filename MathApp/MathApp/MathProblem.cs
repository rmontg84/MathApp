using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MathApp
{
    public class MathProblem
    {
        private int ValueA { get; set; }
        private int ValueB { get; set; }
        private int Answer { get; set; }

        public string CreateRandomMathProblem()
        {
            ValueA = new Random().Next(0, 20);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            ValueB = new Random().Next(0, 20);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            int _operator = new Random().Next(1, 4);

            if (_operator == 1)
            {
                Answer = ValueA + ValueB;
                return String.Format("{0} + {1} = ", ValueA, ValueB);

            }
            else if (_operator == 2)
            {
                if (ValueA > ValueB)
                {
                    Answer = ValueA - ValueB;
                    return String.Format("{0} - {1} = ", ValueA, ValueB);
                }
                else
                {
                    Answer = ValueB - ValueA;
                    return String.Format("{0} - {1} =", ValueB, ValueA);

                }
            }

            else

            {
                Answer = ValueA*ValueB;
                    return String.Format("{0} * {1} =", ValueA, ValueB);
                }

        }

        public bool ChecksUserInput(string userInput)
        {
            if (Answer == int.Parse(userInput))
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
