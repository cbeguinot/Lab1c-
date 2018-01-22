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
        public Categories category
        {
            get { return m_category; }
            set { m_category = value; }
        }
        public int price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public ArtPiece(String t, Categories c, int p)
        {
            title = t;
            category = c;
            price = p;
        }

        public int CompareTo(object o) {
            return this.price.CompareTo((o as ArtPiece).price);
        }

        override
        public String ToString()
        {
            return "Cette piece se nomme " + title + 
                ", appartient a la categorie " + category + 
                " et coute " + price + 
                ".";
        }
    }
}
