﻿using diga.bl.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace diga.bl.Models.Platform.MangoPay
{
    public class PlatformMangoPayUserKYCDocument : IDbServiceEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string MangoPayId { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }

        [ForeignKey("ApplicationUser")]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
