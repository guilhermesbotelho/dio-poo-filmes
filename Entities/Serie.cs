using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_filmes
{
    public class Serie : AbstractClass
    {
        public Serie(int Id, Genre Genre, string Tittle, string Sinopse, int ReleaseYear)
        {
            this.Id = Id;
            this.Genre = Genre;
            this.Tittle = Tittle;
            this.Sinopse = Sinopse;
            this.ReleaseYear = ReleaseYear;
            this.Deleted = false;
        }
        private Genre Genre { get; set; }
        private string Tittle { get; set; }
        private string Sinopse { get; set; }
        private int ReleaseYear { get; set; }
        private bool Deleted { get; set; }

        public override string ToString()
        {
            string details = "";
            details += "Genre: " + this.Genre + Environment.NewLine;
            details += "Tittle: " + this.Tittle + Environment.NewLine;
            details += "Sinopse: " + this.Sinopse + Environment.NewLine;
            details += "Release Year: " + this.ReleaseYear + Environment.NewLine;
            details += "Deleted: " + this.Deleted;
            return details;
        }  

        public string getTittle()
        {
            return this.Tittle;
        }

        public int getId()
        {
            return this.Id;
        }

        public bool getDeleted()
        {
            return this.Deleted;
        }

        public void Delet(){
            this.Deleted = true;
        }
    }
}