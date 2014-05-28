using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliDrago
{
    class ConnexionItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public ConnexionItem(string t, string v)
        {
            this.Text = t;
            this.Value = v;
        }

             
    }
}
