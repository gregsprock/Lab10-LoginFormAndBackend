using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab10_LoginFormAndBackend.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger _log;
        public LoginModel(ILogger<LoginModel> log)
        {
            _log = log;
        }
        public void OnGet()
        {
            Object b = null;
            if (b == null) _log.LogWarning("Object is null!");
            else b.ToString();
        }
        [BindProperty]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [BindProperty]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [BindProperty]
        [Required]
        [CreditCard]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Credit Card")]
        public string CreditCard { get; set; }
        public void OnPost()
        {
            _log.LogWarning($"First Name: {FirstName}  Last Name: {LastName}");
        }
    }
}