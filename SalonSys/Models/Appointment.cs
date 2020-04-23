using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalonSys.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("StaffID")]
        public Staff Staff { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<DateTime> AppointmentDate { get; set; }
        public decimal Charges { get; set; }
    }
}
