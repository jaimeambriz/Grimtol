using CastleGrimtolData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastleGrimtolData
{
    internal class FakeDb
    {
        public List<Library> Libraries = new List<Library>();

        public FakeDb()
        {
            var bL = new Library("Boise Lib", "123 fake str");
            var nL = new Library("Nampa Lib", "127 fake str");
            Libraries.Add(bL);
            Libraries.Add(nL);

            Book mobyDick = new Book("Moby Dick", "das90fudas", "Herman Wells");
            Book awesome = new Book("D$'s Awesome Guide to D&D", "39487237", "D Money");
            Book readyplayerone = new Book("Ready Player One", "4435ihhf", "Jake Overall");
            var battlefield1942 = new VideoGame()
            {
                Name = "Battlefield 1942",
                Platform = "PC"
            };

            var dnd121 = new Magazine("DnD", 121);

            bL.AddItem(mobyDick);
            bL.AddItem(awesome);
            bL.AddItem(readyplayerone);
            bL.AddItem(battlefield1942);
            bL.AddItem(dnd121);

            Book myFavoriteSWCharacterKylo = new Book("Kylo is the best!!!!", "i <3 Kylo", "Jake Christopherson");
            nL.AddItem(myFavoriteSWCharacterKylo);

        }

    }
}