using Microsoft.EntityFrameworkCore;
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BCS.JobProcessing.Client.Models;

[Table("ValidateGutOdsPremiumData", Schema = "Validate")]
public partial class ValidateGutOdsPremiumDataDTO
{
    [Key]
    public long GutOdsPremiumId { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string AccountingPeriod { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string SourceSystemSubCode { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string Company { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string MP { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string CoverageCode { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string PremiumSrcType { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string AmountType { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal GutenbergRaw { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal GutenbergGross { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal ODS { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal DiffRawvsGross { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal DiffGrossvsODS { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal GutenbergRawSuspended { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal GutenbergGrossSuspended { get; set; }

    [Column(TypeName = "numeric(13, 6)")]
    public decimal ODSError { get; set; }
}
