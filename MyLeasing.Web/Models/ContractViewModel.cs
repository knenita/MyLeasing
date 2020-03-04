using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class ContractViewModel : Contract
    {
        public int OwnerId { get; set; }//ligar al contrato el owner

        public int PropertyId { get; set; } //ligar al contrato la propiedad

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Lessee")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a lessee.")]
        public int LesseeId { get; set; }

        public IEnumerable<SelectListItem> Lessees { get; set; }//origen de datos de los arrendatarios
    }
}