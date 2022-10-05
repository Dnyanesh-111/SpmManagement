using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SpmManagement.Models
{
    public class ProjectModel
    {
        //Fields
        private int id;
        private string name;
        private string client;
        private string requirements;
        private string team;
        private int cost;
        private string sdate;
        private string cdate;
        private string status;

        //Properties - Validation

        [DisplayName("Project Id")]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        [DisplayName("Name")]
        [Required(ErrorMessage ="Project name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Project name must be between 3 and 50 characters")]
        public string PName 
        { 
            get => name; 
            set => name = value; 
        }

        [DisplayName("Client")]
        [Required(ErrorMessage = "Client name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Client name must be between 3 and 50 characters")]
        public string Client 
        { 
            get => client; 
            set => client = value; 
        }

        [DisplayName("Requirements")]
        [Required(ErrorMessage = "Requirements are required")]
        public string Requirements 
        { 
            get => requirements; 
            set => requirements = value; 
        }

        [DisplayName("Team Working On")]
        [Required(ErrorMessage = "Team is required")]
        public string Team 
        { 
            get => team; 
            set => team = value; 
        }

        [DisplayName("Toatal Cost")]
        [Required(ErrorMessage = "Cost is required")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$", ErrorMessage = "Please enter onliy integral value")]
        public int Cost 
        { 
            get => cost; 
            set => cost = value; 
        }

        [DisplayName("Staring Date")]
        [Required(ErrorMessage = "Starting date is required")]
        public string Sdate 
        { 
            get => sdate; 
            set => sdate = value; 
        }

        [DisplayName("Completion Date")]
        [Required(ErrorMessage = "Completion date is required")]
        public string Cdate
        { 
            get => cdate; 
            set => cdate = value; 
        }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Please select the status")]
        public string Status 
        { 
            get => status; 
            set => status = value; 
        }
    }
}
