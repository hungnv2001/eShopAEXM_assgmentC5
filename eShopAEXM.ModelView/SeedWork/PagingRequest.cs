using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.ModelView.SeedWork
{
    public class PagingRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 1;
    }
}
