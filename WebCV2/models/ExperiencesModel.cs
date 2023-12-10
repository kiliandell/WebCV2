using System.ComponentModel.DataAnnotations;

namespace WebCV2.models
{
    public class ExperiencesModel
    {
        [Key]
        public int? idexperiences {  get; set; }

        public string? duree {  get; set; }

        public string? title { get; set; }

        public string? description { get; set; }

        public string? lieu { get; set; }

        public ExperiencesModel() { }

        public ExperiencesModel(int? idexperiences, string? duree, string? title, string? description, string? lieu)
        {
            this.idexperiences = idexperiences;
            this.duree = duree;
            this.title = title;
            this.description = description;
            this.lieu = lieu;
        }
    }
}
