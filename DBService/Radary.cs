namespace DBService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Radary")]
    public partial class Radar
    {
        public int id { get; set; }

        [StringLength(5)]
        public string Nazwa { get; set; }

        public int? DopuszczlnaPredkosc { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        public int? Kierunek { get; set; }

        [StringLength(23)]
        public string Wlasciciel { get; set; }
    }
}
