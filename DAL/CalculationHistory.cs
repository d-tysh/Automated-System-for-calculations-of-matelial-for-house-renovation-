namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalculationHistory")]
    public partial class CalculationHistory
    {
        public int Id { get; set; }

        public DateTime? CalcTime { get; set; }

        public int? UserId { get; set; }

        public float? ObjectLength { get; set; }

        public float? ObjectHeight { get; set; }

        public float? ObjectWidth { get; set; }

        public int? NuberWindow { get; set; }

        public float? WidthWindow { get; set; }

        public float? HeightWindow { get; set; }

        public int? NumberDoors { get; set; }

        public float? WidthDoors { get; set; }

        public float? HeightDoors { get; set; }

        public virtual User User { get; set; }
    }
}
