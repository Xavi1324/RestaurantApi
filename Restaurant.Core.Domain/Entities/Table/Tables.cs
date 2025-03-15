using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Enums;
using Restaurant.Core.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities.Table
{
    public class Tables : BaseEntity
    {
        public int Capacity { get; set; }
        public string Description { get; set; }
        public TableStatus Status { get; set; } = TableStatus.Available;
        public ICollection<Orders> orders { get; set; } = new List<Orders>();
    }
}
