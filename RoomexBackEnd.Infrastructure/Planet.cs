namespace RoomexBackEnd.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Planet")]
    public partial class Planet
    {
        public Guid PlanetId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long Distance { get; set; }
    }
}
