﻿using System;

namespace PensionerDetailsService.Models
{
    public class PensionerDetail
    {
        public string AadharNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PAN { get; set; }
        public double SalaryEarned { get; set; }
        public double Allowances { get; set; }
        public string PensionType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BankType { get; set; }
        
    }
}
