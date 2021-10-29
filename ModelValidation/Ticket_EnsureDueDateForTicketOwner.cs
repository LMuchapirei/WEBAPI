

using System.ComponentModel.DataAnnotations;
using WEBAPI.Models;

namespace WEBAPI.ModelValidations{


    public class Ticket_EnsureDateForTicketOwner : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket=validationContext.ObjectInstance as Ticket;
            if(ticket !=null && !string.IsNullOrWhiteSpace(ticket.Owner)){
                if(!ticket.DueDate.HasValue)
                
                    return new ValidationResult("Due date is required when the ticket has an owner");
                
            }
            return ValidationResult.Success;
        }
    }
}
    

// We can use this to validate stuff because we have access to the validation context