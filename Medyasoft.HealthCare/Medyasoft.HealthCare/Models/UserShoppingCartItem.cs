using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.Models
{
    public class UserShoppingCartItem
    {
        public string UserId { get; set; }
        public ShoppingCartItem ShoppingCartItem { get; set; }
    }
}
