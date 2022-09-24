using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SpmManagement.Models
{
	public class RequirementModel
	{
		//Fields
		private int id;
		private string client;
		private string file;

		//Properties - Validation
		[DisplayName("Id")]
		public int Id
		{
			get => id;
			set => id = value;
		}

		[DisplayName("Client")]
		[Required(ErrorMessage ="Please select client")]
		public string Client
		{
			get => client;
			set => client = value;
		}

		[DisplayName("File")]
		[Required(ErrorMessage ="Please select file to upload")]
		public string File
		{
			get => file;
			set => file = value;
		}
	}
}
