using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace leaveManagement.Web.Data
{
	public class LeaveAllocation
	{
		public int Id { get; set; }
		public int NumberOfDays { get; set; }

		//allocations have a reference for leave type
		[ForeignKey("LeaveTypeId")]
		public LeaveType LeaveType { get; set; }
		public int LeaveTypeId { get; set; }

		//Allocate leave type to employee
		public string EmployeeId { get; set; }

		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
	}
}

