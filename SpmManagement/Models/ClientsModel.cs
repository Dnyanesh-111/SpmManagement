using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.ComponentModel.DataAnnotations;using System.ComponentModel;namespace SpmManagement.Models{	public class ClientsModel	{		//Fields		private int id;		private string name;		private string email;		private string mobile;		private string city;		private string state;		private string country;
		

		//Properties - Validation
		[DisplayName("Id")]
        public int Id 
		{ 
			get => id; 
			set => id = value; 
		}

		[DisplayName("Name")]
		[Required(ErrorMessage ="Client name is required")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="Client name must be between 3 and 50 characters")]
		public string Name 
		{ 
			get => name; 
			set => name = value; 
		}

		[DisplayName("Email")]
		[Required(ErrorMessage = "Client email is required")]
		[RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="Please enter valid email")]
		public string Email 
		{ 
			get => email; 
			set => email = value; 
		}

		[DisplayName("Mobile Number")]
		[Required(ErrorMessage = "Client email is required")]
		[StringLength(50, ErrorMessage = "Client name must be between 3 and 50 characters")]
		[RegularExpression(@"^\$?\d+(\.(\d{2}))?$",ErrorMessage ="Please enter valid mobile number")]
		public string Mobile 
		{ 
			get => mobile; 
			set => mobile = value; 
		}

		[DisplayName("City")]
		[Required(ErrorMessage = "Client city is required")]
		[StringLength(50,MinimumLength = 4 ,ErrorMessage = "Client city must be between 4 and 50 characters")]
		[RegularExpression("/^[A-Za-z]+$/")]
		public string City 
		{ 
			get => city; 
			set => city = value; 
		}

		[DisplayName("State")]
		[Required(ErrorMessage = "Client State is required")]
		[StringLength(50, MinimumLength = 4, ErrorMessage = "Client state must be between 4 and 50 characters")]
		[RegularExpression("/^[A-Za-z]+$/")]
		public string State 
		{ 
			get => state; 
			set => state = value; 
		}

		[DisplayName("Country")]
		[Required(ErrorMessage = "Client country is required")]
		[StringLength(50, MinimumLength = 4, ErrorMessage = "Client contry must be between 4 and 50 characters")]
		[RegularExpression("/^[A-Za-z]+$/")]
		public string Country 
		{ 
			get => country; 
			set => country = value; 
		}
    }}