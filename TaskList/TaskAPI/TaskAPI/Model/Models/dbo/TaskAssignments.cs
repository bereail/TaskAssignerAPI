﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TaskAPI.Models
{
    public partial class TaskAssignments
    {
        public int AssignmentId { get; set; }
        public int? TaskId { get; set; }
        public int? AdminId { get; set; }
        public int? UserId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string Comment { get; set; }

        public virtual Administrators Admin { get; set; }
        public virtual Tasks Task { get; set; }
        public virtual Users User { get; set; }
    }
}