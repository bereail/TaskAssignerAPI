﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TaskAPI.Models
{
    public partial class Administrators
    {
        public Administrators()
        {
            TaskAssignments = new HashSet<TaskAssignments>();
        }

        public int AdminId { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<TaskAssignments> TaskAssignments { get; set; }
    }
}