namespace StateTrafficInspectorateApp.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string Patronymic { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        [StringLength(100)]
        public string RegistrationAddress { get; set; }

        [StringLength(100)]
        public string ResidentialAddress { get; set; }

        public int? Company { get; set; }

        public int? JobName { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Photo { get; set; }

        public string Comment { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Job Job { get; set; }
    }
}
