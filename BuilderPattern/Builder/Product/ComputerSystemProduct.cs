using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerSystemProduct
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }
        public string Mouse { get; set; }
        public string KeyBoard { get; set; }
        public string TouchScreen { get; set; }

        public ComputerSystemProduct()
        {
        }

        public string GetFinalProduct(ComputerSystemProduct obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("RAM: {0}", obj.RAM));
            sb.Append(string.Format("HDDSize: {0}", obj.HDDSize));
            sb.Append(string.Format("Mouse: {0}", obj.Mouse));
            sb.Append(string.Format("KeyBoard: {0}", obj.KeyBoard));
            sb.Append(string.Format("TouchScreen: {0}", obj.TouchScreen));

            return sb.ToString();
        }
    }
}
