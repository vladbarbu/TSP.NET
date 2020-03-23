using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ClassLibraryNetCore.Model
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        [MaxLength(20)]
        public string TotalValue { get; set; }
        [MaxLength(50)]
        public DateTime Date { get; set; }
        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        //public int Deleted { get; set; }
        protected Orders() { }
    }
}