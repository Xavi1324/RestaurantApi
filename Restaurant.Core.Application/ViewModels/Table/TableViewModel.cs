﻿using Restaurant.Core.Domain.Entities.Enums;

namespace Restaurant.Core.Application.ViewModels.Table
{
    public class TableViewModel
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public TableStatus Status { get; set; }
    }
}
