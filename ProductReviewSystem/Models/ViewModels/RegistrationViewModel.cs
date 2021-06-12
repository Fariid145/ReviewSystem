using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewSystem.Models.ViewModels
{
    public class RegistrationViewModel  : LoginViewModel
    {
        public string Name { get; set; }   

        public string Type { get; set; }
    }
}



