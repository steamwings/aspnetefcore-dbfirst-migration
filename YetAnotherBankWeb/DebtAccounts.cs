﻿using System;
using System.Collections.Generic;

namespace YetAnotherBankWeb
{
    public partial class DebtAccounts
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public decimal PaymentAmount { get; set; }
        public int PaymentsBehind { get; set; }
        public DateTime NextPaymentDue { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
