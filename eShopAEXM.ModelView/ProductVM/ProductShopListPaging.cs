using eShopAEXM.ModelView.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.ModelView.ProductVM
{
	public class ProductShopListPaging : PagingRequest
	{
		public List<ProductDTO> Data { get; set; }
		public int TotalPage { get; set; }
		public bool HasNext => PageIndex < TotalPage;
		public bool HasPrevious => PageIndex ==1;


	}
}
