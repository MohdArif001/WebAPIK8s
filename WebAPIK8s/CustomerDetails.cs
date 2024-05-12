﻿using Microsoft.EntityFrameworkCore;

namespace WebAPIK8s
{
    [Keyless]
    public class CustomerDetails
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerNumber { get; set; }
        public int CustomerPinCode { get; set; }
    }
}
