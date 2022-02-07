namespace StateTrafficInspectorateApp.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [Key]
        [StringLength(50)]
        public string VIN { get; set; }

        public int? Manufacturer { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Year { get; set; }

        public int? Weight { get; set; }

        public int? Color { get; set; }

        public int? EngineType { get; set; }

        public int? TypeOfDrive { get; set; }

        public virtual CarManufacturer CarManufacturer { get; set; }

        public virtual TypeOfDrive TypeOfDrive1 { get; set; }
    }
}
