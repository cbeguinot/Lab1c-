using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class ArtGalery: IArtSelect
    {
        //Collection of ArtPieces
        private List<ArtPiece> m_Collection =  new List<ArtPiece>();
        public List<ArtPiece> collection
        {
            get { return m_Collection; }
            set { m_Collection = value; }
        }

        //initialization method
        public void initialize()
        {
            m_Collection.Add(new ArtPiece("Bold and Brash", Categories.PAINTING, 140));
            m_Collection.Add(new ArtPiece("Le Brasseur", Categories.SCULPTURE, 40));
            m_Collection.Add(new ArtPiece("L'Uomo Vitruviano", Categories.DRAWING, 200));
            m_Collection.Add(new ArtPiece("PopArt", Categories.PAINTING, 105));
            m_Collection.Add(new ArtPiece("Le Penseur", Categories.SCULPTURE, 180));
            m_Collection.Add(new ArtPiece("Picasso Sketch", Categories.DRAWING, 193));
            m_Collection.Add(new ArtPiece("Un Serpent Boa qui Digérait un éléphant", Categories.DRAWING, 25));
            m_Collection.Add(new ArtPiece("Mouton Dessiné", Categories.DRAWING, 78));
            m_Collection.Add(new ArtPiece("Gernika", Categories.PAINTING, 135));
            m_Collection.Add(new ArtPiece("Belongs in the Trash", Categories.PAINTING, 20));
            m_Collection.Add(new ArtPiece("Davide de Bernini", Categories.SCULPTURE, 130));
            m_Collection.Add(new ArtPiece("Badly Shapen Pot", Categories.SCULPTURE, 25));
        }

        //ProcessArtPiece method receiving IArtSelect as arg
        //Responsible for printing selected ArtPieces
        public void processArtPiece(IArtSelect arg)
        {
            List<ArtPiece> galerySelected = new List<ArtPiece>();

            foreach (ArtPiece piece in m_Collection)
            {
                if (arg.select(piece)==true)
                    galerySelected.Add(piece);
            }

            foreach (ArtPiece piece in galerySelected)
            {
                System.Console.WriteLine(piece.ToString());
            }
        }

        bool IArtSelect.select(ArtPiece artPiece)
        {
            if(artPiece.price > 150)
                return true;
            else
                return false;
        }

        //Tri la gallerie par prix croissant
        public List<ArtPiece> sort()
        {
            List<ArtPiece> galerySorted = m_Collection.OrderBy(x => x.price).ToList();
            //Si on veut trier complètement m_Collection :
            m_Collection = galerySorted;
            return galerySorted;
        }
    }
}
