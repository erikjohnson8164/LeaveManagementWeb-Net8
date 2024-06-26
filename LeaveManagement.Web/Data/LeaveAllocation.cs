﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }

        [ForeignKey("LeaveTypeId")]
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }

        public int Period {  get; set; }

    }
}
