using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.ViewModels
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required ( ErrorMessage = "This Field can not be empty")]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}
