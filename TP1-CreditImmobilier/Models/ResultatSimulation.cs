using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TP1_CreditImmobilier.Models
{
    public class ResultatSimulation
    {
        [DisplayName("simulation")]
        Simulation simulation { get; set;}

        [DisplayName("liste amortissement")]
        public List<TableauAmortissement> amortissemntList { get; set; }

        [DisplayName("taux total interet")]
        public double tauxTotaleInteret { get; set; }

        [DisplayName("taux total assurance")]
        public double tauxTotaleAssurance { get; set; }

        [DisplayName("cout totale pret")]
        public double coutTotalePret { get; set; }
    }
}