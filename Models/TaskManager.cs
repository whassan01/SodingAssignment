using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SodingAssignment.Models
{
    [DisplayName("Task")]
    public class TaskManager
    {
        public int TaskManagerID { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Description { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Updated Date")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }
    }
}