using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrazyBooking.Model
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedDt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "Admin";
        public DateTime ModifiedDt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }="Admin";
        public bool IsActive { get; set; } = true;
        public bool isDeleted { get; set; } = false;

    }
}
