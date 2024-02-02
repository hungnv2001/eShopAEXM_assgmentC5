using eShopAEXM.ModelView.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.ModelView.ProductVM
{
    public class GetProductWithPagingRequest: PagingRequest
    {
        public string? keySearch;
    }
}
