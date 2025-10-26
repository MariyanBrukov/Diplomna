using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Build
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Build Name")]
        public string BuildName { get; set; }

        // Foreign keys
        [Display(Name = "CPU")]
        public int CPUId { get; set; }

        [Display(Name = "GPU")]
        public int GPUId { get; set; }

        [Display(Name = "Motherboard")]
        public int MotherboardId { get; set; }

        [Display(Name = "RAM")]
        public int RAMId { get; set; }

        [Display(Name = "Storage")]
        public int StorageId { get; set; }

        [Display(Name = "Power Supply")]
        public int PowerSupplyId { get; set; }

        [Display(Name = "Case")]
        public int CaseId { get; set; }

        // Navigation properties
        [ForeignKey("CPUId")]
        public virtual CPU? CPU { get; set; }

        [ForeignKey("GPUId")]
        public virtual GPU? GPU { get; set; }

        [ForeignKey("MotherboardId")]
        public virtual Motherboard? Motherboard { get; set; }

        [ForeignKey("RAMId")]
        public virtual RAM? RAM { get; set; }

        [ForeignKey("StorageId")]
        public virtual Storage? Storage { get; set; }

        [ForeignKey("PowerSupplyId")]
        public virtual PowerSupply? PowerSupply { get; set; }

        [ForeignKey("CaseId")]
        public virtual Case? Case { get; set; }

        [Display(Name = "Total Price")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
    }
}
