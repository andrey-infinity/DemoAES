using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAES
{
       public class ViewStateArgs : EventArgs
        {
            public ViewStateArgs(Matrix _m)
            {
                this.StateMatrix = _m;
            }
            public Matrix StateMatrix;
        }
       public class EndStateArgs : EventArgs
        {
            public EndStateArgs(bool a)
            {
                this.isEnd = a;
            }
            public bool isEnd;
        }
}
