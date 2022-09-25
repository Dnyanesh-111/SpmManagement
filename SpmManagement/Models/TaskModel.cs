using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SpmManagement.Models
{
    public class TaskModel
    {
		//Fields
		private int id;
		private string project;
		private string name;
		private string description;
		private string assignedTo;
		private string duration;
		private string dependency;
		private string status;
        private string work;

        //Properties - Validation
        [DisplayName("Id")]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        [DisplayName("Project")]
        [Required(ErrorMessage ="Project name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Project name must be between 3 and 50 characters")]
        public string Project 
        { 
            get => project; 
            set => project = value; 
        }

        [DisplayName("Task Name")]
        [Required(ErrorMessage ="Task name is required")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="Task name must be between 4 to 50 characters")]
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        [DisplayName("Discription")]
        [Required(ErrorMessage ="Task discription is required")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "Task dicription must be between 15 to 50 characters")]
        public string Description 
        { 
            get => description; 
            set => description = value; 
        }

        [DisplayName("Assigned To")]
        [Required(ErrorMessage ="Please assign task to someone")]
        public string AssignedTo 
        { 
            get => assignedTo; 
            set => assignedTo = value; 
        }

        [DisplayName("Duration")]
        [Required(ErrorMessage ="Task duration is required")]
        public string Duration 
        { 
            get => duration; 
            set => duration = value; 
        }

        [DisplayName("Status")]
        [Required(ErrorMessage ="Please select the status")]
        public string Status 
        { 
            get => status; 
            set => status = value; 
        }

        [DisplayName("Task Dependancy")]
        public string Dependency 
        { 
            get => dependency; 
            set => dependency = value; 
        }

        [DisplayName("Work")]
        public string Work 
        { 
            get => work; 
            set => work = value; 
        }
    }
}
