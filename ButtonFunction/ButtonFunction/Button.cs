using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFunction
{
    public delegate void Click(string text);
    public class Button
    {
        public event Click Click;
        public void OnClick()
        {
            Click("Click");
        }
    }
}
