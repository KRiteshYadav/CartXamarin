using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBuy.Models
{
    class Cart
    {
        public virtual long CartId { get; set; }
        public virtual long UserId { get; set; }

        public virtual long CartItemId { get; set; }

        public virtual long Quantity { get; set; }
    }
}
