using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDouglas
{
    public class WhishlistItem
    {
        private string title;

        public string Title
        {
            get
            {
                return title + "2";
            }
            set => title = value + "hallo";
        }
        public int Price { get; set; }
    }
}
