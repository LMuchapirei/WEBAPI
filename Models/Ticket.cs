


using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.ModelValidations;

namespace WEBAPI.Models{
    public class Ticket{
        [Required]
        public int? TicketId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        public string  Description { get; set; }
        public string  Owner { get; set; }

        [Ticket_EnsureDateForTicketOwner]
        [Ticket_EnsureDueDateInFuture]
        public DateTime? DueDate { get; set; }
    }
}