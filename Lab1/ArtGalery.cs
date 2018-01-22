﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ArtGalery
    {
        private List<ArtPiece> m_Collection =  new List<ArtPiece>();


        private void initialize()
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

        public void processArtPiece()
        {

        }

        public void select()
        {

        }

        public void sort()
        {

        }
    }
}
