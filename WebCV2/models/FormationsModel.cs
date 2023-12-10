using System.ComponentModel.DataAnnotations;

namespace WebCV2.models
{
    public class FormationsModel
    {
        [Key]
        public int? idformations {  get; set; }

        public string? title { get; set; }

        public string? description { get; set; }

        public string? etablissement { get; set; }

        public string? lieu {  get; set; }

        public FormationsModel() { }

        public FormationsModel(int? idformations, string? title, string? description, string? etablissement, string? lieu)
        {
            this.idformations = idformations;
            this.title = title;
            this.description = description;
            this.etablissement = etablissement;
            this.lieu = lieu;
        }
    }
}
