﻿using diga.bl.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diga.bl.Models.Platform.Users
{
    public class PlatformCompany : IDbServiceEntity<int>
    {
        [Key, ForeignKey("ApplicationUser")]
        public int Id { get; set; }
        public string OrganizationType { get; set; }
        public string Name { get; set; }
        public string LegalAddress { get; set; }
        public string MailingAddress { get; set; }
        public string TaxpayerNumber { get; set; }
        public string CheckingAccount { get; set; }
        public string CorrespondentAccount { get; set; }
        public string BankIdentificationCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Site { get; set; }
        public string Email { get; set; }
        public string CompanyGroup { get; set; }
        public string About { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
