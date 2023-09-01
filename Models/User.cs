using System;
using System.Collections.Generic;

namespace ICDWebApi.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? UserType { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? SupervisorEmail { get; set; }
}
