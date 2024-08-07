﻿using System.ComponentModel.DataAnnotations;

namespace InventoryIT.Model
{
    public class ComputerModel
    {
        [Key]
        public int ComputerModelID { get; set; }
        public string SerialNumber { get; set; }
        public string ModelName { get; set; }
        public DateTime AdquisitionDate { get; set; }
        public string Cost { get; set; }
        public bool HaveSSD { get; set; }
        public int SizeDisk { get; set; }
        public int SizeRAM { get; set; }
        public string RAMType { get; set; }
        public string Description { get; set; }
        public string KeyboardLayout { get; set; }
        public string Processor { get; set; }
        public bool HasNumericKeyboard { get; set; }
        public bool IsActive { get; set; }
        public ICollection<HistoryModel>? Histories { get; set; }
        public ICollection<FileModel>? Files { get; set; }
        public ICollection<ImageModel>? Image { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }

        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }
    }
}
