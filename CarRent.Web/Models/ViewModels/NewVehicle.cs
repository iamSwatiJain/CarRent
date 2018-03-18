using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Web.Models.ViewModels
{
    public class NewVehicle
    {
        [DisplayName("Type")]
        public VehicleType Type { get; set; }

        [StringLength(2)]
        [DisplayName("Registration Number")]
        [RegularExpression("[a-zA-Z]{1}[0-9]{1}", ErrorMessage = "Format: ABC123")]
        public VehicleType RegistrationNo { get; set; }

    }
}