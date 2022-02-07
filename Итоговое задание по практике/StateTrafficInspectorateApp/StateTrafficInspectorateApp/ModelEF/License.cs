namespace StateTrafficInspectorateApp.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LicenceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }

        [StringLength(20)]
        public string Categories { get; set; }

        [Column("License")]
        [StringLength(50)]
        public string License1 { get; set; }

        public int? Status { get; set; }

        public virtual Status Status1 { get; set; }
    }
}
