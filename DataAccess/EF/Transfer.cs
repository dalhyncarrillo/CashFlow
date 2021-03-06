﻿using System;
using System.Collections.Generic;

namespace CashFlow.DataAccess.EF
{
    public partial class Transfer
    {
        public long Id { get; set; }
        public long AccountFromId { get; set; }
        public long AccountToId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }

        public virtual Account AccountFrom { get; set; }
        public virtual Account AccountTo { get; set; }
    }
}
