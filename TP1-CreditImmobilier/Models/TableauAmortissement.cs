using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TP1_CreditImmobilier.Models
{
    public class TableauAmortissement
    {
        [DisplayName("capitale restant")]
        public double capitalRestant { get; set; }

        [DisplayName("interet echeance")]
        public double interetEcheance { get; set; }

        [DisplayName("capital rembourse")]
        public double capitalRemboursse { get; set; }

        [DisplayName("frais echeance")]
        public double fraisEcheance { get; set; }

        [DisplayName("montant reel echeance")]
        public double montanteReelEcheance { get; set; }
    }
}