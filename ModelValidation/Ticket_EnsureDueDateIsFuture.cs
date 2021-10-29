

using System;
using System.ComponentModel.DataAnnotations;
using WEBAPI.Models;

namespace WEBAPI.ModelValidations
{


    public class Ticket_EnsureDueDateInFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            // When creating ticket, ticket due date has to be in the future
            if(ticket !=null && ticket.TicketId==null){
                if(ticket.DueDate.HasValue && ticket.DueDate.Value <DateTime.Now){
                        return new ValidationResult("Due date is less than today's date");
                }
            }
            return ValidationResult.Success;

            // my shortsighted stuff
            // if (ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
            // {
            //     if (ticket.DueDate.HasValue)

            //     {
            //         var res=DateTime.Compare(DateTime.Now,ticket.DueDate.Value);
            //         if(res>0)
            //             return new ValidationResult("Due date is less than today's date");
            //     }

            // }
            // return ValidationResult.Success;
        }
    }
}


// We can use this to validate stuff because we have access to the validation context