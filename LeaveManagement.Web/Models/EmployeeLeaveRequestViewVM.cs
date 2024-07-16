namespace LeaveManagement.Web.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAlloctions, List<LeaveRequestVM> leaveRequests)
        {
            LeaveAllocations = leaveAlloctions;
            LeaveRequests = leaveRequests;
             
        }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }

    }
}
