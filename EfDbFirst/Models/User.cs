﻿using System;
using System.Collections.Generic;

namespace EfDbFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public bool IsReviewer { get; set; }

    public bool IsAdmin { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
