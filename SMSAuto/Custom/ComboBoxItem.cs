using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSAuto.Custom
{
    class ComboBoxItem
    {
        public string Name;
        public int Value;
        public string ValueString;
        public ComboBoxItem(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public ComboBoxItem(string Name, string Value)
        {
            this.Name = Name;
            this.ValueString = Value;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
