using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TP1_CreditImmobilier.Models
{
    public class Simulation 
    {

        [DisplayName ("nom client")]
        public String clientName  { get; set;}

        [DisplayName("date")]
        public DateTime date { get; set; }

        [DisplayName("capital emprunté")]
        [Required (ErrorMessage ="missed data")]
        public double    empruntedCapital { get; set; }

        [DisplayName("durée du crédit en mois")]
        [Required(ErrorMessage = "missed data")]
        public int dureCreditMois { get; set; }

        [DisplayName("nombre d’échéances par an")]
        [Required(ErrorMessage = "missed data")]
        public int nbrEcheance { get; set; }

        [DisplayName("montant des échéances")]
        [Required(ErrorMessage = "missed data")]
        public double montantEcheance { get; set; }

        [DisplayName("taux  intérêt annuel")]
        [Required(ErrorMessage = "missed data")]
        public double tauxInteretAnnuel { get; set; }

        [DisplayName("taux assurance")]
        [Required(ErrorMessage = "missed data")]
        public double tauxAssurance { get; set; }

        
        [DisplayName("taux intérêt périodique")]
        [Required(ErrorMessage = "missed data")]
        public double tauxInteretPeriod { get; set; }

        [DisplayName("taux périodique assurance")]
        [Required(ErrorMessage = "missed data")]
        public double tauxAssurancePeriod { get; set; }

        [DisplayName("montant des echeances assurance")]
        public double montantEcheanceAssurrance { get; set; }

        public Simulation()
        {

        }
        public  Simulation(String name, DateTime date){
            this.clientName = name;
            this.date = date;
        }
    }
}