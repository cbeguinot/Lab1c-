using System;
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

            //afficher les pièces triées
            List<ArtPiece> galerySorted = artGalery.sort();
            Console.WriteLine(galerySorted[0].title);


            Console.WriteLine("salut");
        }

        class PaintingOver100 : IArtSelect
        {
            bool IArtSelect.ArtSelect(ArtPiece artPiece)
            {
                throw new NotImplementedException();
            }
        }
        class SculptureUnder100 : IArtSelect
        {
            bool IArtSelect.ArtSelect(ArtPiece artPiece)
            {
                throw new NotImplementedException();
            }
        }
    }
}
