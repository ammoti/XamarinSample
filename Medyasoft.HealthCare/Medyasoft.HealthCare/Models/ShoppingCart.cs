using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public string UserId { get; set; }
        public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
