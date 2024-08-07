﻿using LeaveManagement.Web.Controllers;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task CancelLeaveRequest(int leaveRequestId);
    }
}
