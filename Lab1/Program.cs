﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Process();
            System.Console.ReadLine();
        }

        private void Process()
        {
            //Init artGalery
            ArtGalery artGalery = new ArtGalery();
            artGalery.initialize();
            System.Console.WriteLine("initialisation ok");


            //afficher les pièces triées
            System.Console.WriteLine("\npièces triées par prix :");
            List<ArtPiece> galerySorted = artGalery.sort();
            foreach (ArtPiece piece in galerySorted)
            {
                System.Console.WriteLine(piece.ToString());
            }

            //PaintingOver100 :
            System.Console.WriteLine(" \nPaintingOver100");
            PaintingOver100 selection1 = new PaintingOver100();
            artGalery.processArtPiece(selection1);

            //SculptureUnder100 :
            System.Console.WriteLine("\nSculptureUnder100 : ");
            SculptureUnder100 selection2 = new SculptureUnder100();
            artGalery.processArtPiece(selection2);

            //Select over 150
            System.Console.WriteLine("\nOver150 : ");
            artGalery.processArtPiece(artGalery);

        }

        class PaintingOver100 : IArtSelect
        {
            bool IArtSelect.select(ArtPiece artPiece)
            {
                //Est-ce que c'est peinture + > 100 ?
                if (artPiece.category == Categories.PAINTING && artPiece.price > 100)
                    return true;
                else
                    return false;

            }
        }
        class SculptureUnder100 : IArtSelect
        {
            bool IArtSelect.select(ArtPiece artPiece)
            {
                //Est-ce que c'est sculpture + < 100 ?
                if (artPiece.category == Categories.SCULPTURE && artPiece.price < 100)
                    return true;
                else
                    return false;
            }
        }
    }
}
