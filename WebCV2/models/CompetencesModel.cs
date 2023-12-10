using System.ComponentModel.DataAnnotations;

namespace WebCV2.models
{
    public class CompetencesModel 
    {
        [Key]
        public int? idcompetences { get; set; }

        public string? title { get; set; }

        public string? text_competences { get; set; }

        public CompetencesModel() { }

        public CompetencesModel(int id, string title, string text) 
        {
            this.idcompetences = id;
            this.title = title; 
            this.text_competences = text;   
        }


    }
}
