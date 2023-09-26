using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
	public class ProductDTO
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int CategoryId { get; set; }
		public int UnitsInStock { get; set; }
		public int UnitPrice { get; set; }
		[AllowNull]
		public virtual CategoryDTO? Category { get; set; }
	}
}
