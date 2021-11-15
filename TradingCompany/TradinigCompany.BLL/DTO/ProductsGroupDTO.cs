using System.Collections.Generic;

namespace TradingCompany.BLL.DTO
{
    class ProductsGroupDTO
    {
        public ulong Id { get; set; }
        public virtual ICollection<int> Quantity { get; set; }
        public virtual ICollection<ProductDTO> Categories { get; set; }
    }
}
