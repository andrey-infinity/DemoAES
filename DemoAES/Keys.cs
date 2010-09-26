using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAES
{
    class Keys
    {
        public List<Matrix> RoundKeys = new List<Matrix>(11);
        public void setCipherKey(Matrix CipherKey)
        {
            if (RoundKeys.Count == 0)
            {
                this.RoundKeys.Add(CipherKey);
            }
            else
            {
                RoundKeys.Clear();
                RoundKeys.Add(CipherKey);
            }

            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
            RoundKeys.Add(new Matrix(4, 4));
        }
    }
}
