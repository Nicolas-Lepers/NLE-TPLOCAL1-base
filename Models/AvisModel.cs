using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class AvisModel
    {
        [Required(ErrorMessage ="Le nom est obligatoire")]
        public string Nom {  get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Veuillez selectionner une option")]
        public string Sexe { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est obligatoire")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir 5 chiffres")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "L'adresse mail est obligatoire")]
        [RegularExpression(@"^([\w\.-]+)@([\w\.-]+)\.([a-zA-Z]{2,})$", ErrorMessage = "Adresse mail invalide")]
        [EmailAddress(ErrorMessage = "Adresse mail invalide")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "La date de début est obligatoire")]
        [DataType(DataType.Date)]
        public DateTime? DateDebut { get; set; }

        [Required(ErrorMessage = "Veuillez selectinner une formation")]
        public string Formation { get; set; }

        public string? AvisCobol { get; set; }

        public string? AvisCsharp { get; set; }




    }
}
