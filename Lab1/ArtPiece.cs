using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    enum Categories {PAINTING, DRAWING, SCULPTURE};

    class ArtPiece: IComparable
    {
        private String m_title;
        private Categories m_category;
        private int m_price;

        public String title {
            get { return m_title; }
            set { m_title = value; }
        }
        public Categories category { get; set; }
        public int price { get; set; }

        public ArtPiece(String title, Categories category, int price)
        {
            m_title = title;
            m_category = category;
            m_price = price;
        }

        public int CompareTo(object o) { return this.price.CompareTo((o as ArtPiece).price); }

        override
        public String ToString()
        {
            return "Ceci est une piece artistique !";
        }
    }
}
