﻿using System.Collections;
using System.Collections.Generic;

namespace E_Ticarett.Models
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
