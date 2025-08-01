//namespace BCS.JobProcessing.Host.Models;
//public class GrossPremiumDTO
//{
//    private long _GrossPremiumKey;
//    public long GrossPremiumKey
//    {
//        get { return _GrossPremiumKey; }
//        set { _GrossPremiumKey = value; }
//    }

//    private long _AccountingPeriodKey;
//    public long AccountingPeriodKey
//    {
//        get { return _AccountingPeriodKey; }
//        set { _AccountingPeriodKey = value; }
//    }

//    private DateTime? _PremiumDueStartDate;
//    public DateTime? PremiumDueStartDate
//    {
//        get { return _PremiumDueStartDate; }
//        set { _PremiumDueStartDate = value; }
//    }

//    private long _ResidentStateKey;
//    public long ResidentStateKey
//    {
//        get { return _ResidentStateKey; }
//        set { _ResidentStateKey = value; }
//    }

//    private long _CoverageCodeKey;
//    public long CoverageCodeKey
//    {
//        get { return _CoverageCodeKey; }
//        set { _CoverageCodeKey = value; }
//    }

//    private DateTime? _PremiumDueEndDate;
//    public DateTime? PremiumDueEndDate
//    {
//        get { return _PremiumDueEndDate; }
//        set { _PremiumDueEndDate = value; }
//    }

//    private decimal? _CollectedPremiumAmount;
//    public decimal? CollectedPremiumAmount
//    {
//        get { return _CollectedPremiumAmount; }
//        set { _CollectedPremiumAmount = value; }
//    }

//    private long _PolicyrenewalKey;
//    public long PolicyrenewalKey
//    {
//        get { return _PolicyrenewalKey; }
//        set { _PolicyrenewalKey = value; }
//    }

//    private long _SourceSystemXrefKey;
//    public long SourceSystemXrefKey
//    {
//        get { return _SourceSystemXrefKey; }
//        set { _SourceSystemXrefKey = value; }
//    }

//    private long _CompanyKey;
//    public long CompanyKey
//    {
//        get { return _CompanyKey; }
//        set { _CompanyKey = value; }
//    }

//    private decimal? _EarnedPremiumAmount;
//    public decimal? EarnedPremiumAmount
//    {
//        get { return _EarnedPremiumAmount; }
//        set { _EarnedPremiumAmount = value; }
//    }

//    private long _ManagementProgramKey;
//    public long ManagementProgramKey
//    {
//        get { return _ManagementProgramKey; }
//        set { _ManagementProgramKey = value; }
//    }

//    private decimal? _WrittenPremiumAmount;
//    public decimal? WrittenPremiumAmount
//    {
//        get { return _WrittenPremiumAmount; }
//        set { _WrittenPremiumAmount = value; }
//    }

//    private decimal? _UnearnedPremiumAmount;
//    public decimal? UnearnedPremiumAmount
//    {
//        get { return _UnearnedPremiumAmount; }
//        set { _UnearnedPremiumAmount = value; }
//    }

//    private decimal? _UnpaidPremiumAmount;
//    public decimal? UnpaidPremiumAmount
//    {
//        get { return _UnpaidPremiumAmount; }
//        set { _UnpaidPremiumAmount = value; }
//    }

//    private int? _CollectedNumberOfInsured;
//    public int? CollectedNumberOfInsured
//    {
//        get { return _CollectedNumberOfInsured; }
//        set { _CollectedNumberOfInsured = value; }
//    }

//    private decimal? _BrokerPercent;
//    public decimal? BrokerPercent
//    {
//        get { return _BrokerPercent; }
//        set { _BrokerPercent = value; }
//    }

//    private DateTime? _ActivityDate;
//    public DateTime? ActivityDate
//    {
//        get { return _ActivityDate; }
//        set { _ActivityDate = value; }
//    }

//    private decimal? _AdminPercent;
//    public decimal? AdminPercent
//    {
//        get { return _AdminPercent; }
//        set { _AdminPercent = value; }
//    }

//    private int? _EarnedNumberOfInsured;
//    public int? EarnedNumberOfInsured
//    {
//        get { return _EarnedNumberOfInsured; }
//        set { _EarnedNumberOfInsured = value; }
//    }

//    private decimal? _SourceCollectedNetPremiumAmount;
//    public decimal? SourceCollectedNetPremiumAmount
//    {
//        get { return _SourceCollectedNetPremiumAmount; }
//        set { _SourceCollectedNetPremiumAmount = value; }
//    }

//    private int? _WrittenNumberOfInsured;
//    public int? WrittenNumberOfInsured
//    {
//        get { return _WrittenNumberOfInsured; }
//        set { _WrittenNumberOfInsured = value; }
//    }

//    private int? _UnearnedNumberOfInsured;
//    public int? UnearnedNumberOfInsured
//    {
//        get { return _UnearnedNumberOfInsured; }
//        set { _UnearnedNumberOfInsured = value; }
//    }

//    private int? _UnpaidNumberOfInsured;
//    public int? UnpaidNumberOfInsured
//    {
//        get { return _UnpaidNumberOfInsured; }
//        set { _UnpaidNumberOfInsured = value; }
//    }

//    private string? _TPACode;
//    public string? TPACode
//    {
//        get { return _TPACode; }
//        set { _TPACode = value; }
//    }

//    private DateTime? _InvoiceDate;
//    public DateTime? InvoiceDate
//    {
//        get { return _InvoiceDate; }
//        set { _InvoiceDate = value; }
//    }

//    private long _GutenbergGrossPremiumEntityId;
//    public long GutenbergGrossPremiumEntityId
//    {
//        get { return _GutenbergGrossPremiumEntityId; }
//        set { _GutenbergGrossPremiumEntityId = value; }
//    }

//    private DateTime? _GutenbergStartTs;
//    public DateTime? GutenbergStartTs
//    {
//        get { return _GutenbergStartTs; }
//        set { _GutenbergStartTs = value; }
//    }

//    private long _GutenbergGrossPremiumManualEntityId;
//    public long GutenbergGrossPremiumManualEntityId
//    {
//        get { return _GutenbergGrossPremiumManualEntityId; }
//        set { _GutenbergGrossPremiumManualEntityId = value; }
//    }

//    private long _GutenbergPolicyEntityID;
//    public long GutenbergPolicyEntityID
//    {
//        get { return _GutenbergPolicyEntityID; }
//        set { _GutenbergPolicyEntityID = value; }
//    }

//    private long _GutenbergRawPremiumEntityId;
//    public long GutenbergRawPremiumEntityId
//    {
//        get { return _GutenbergRawPremiumEntityId; }
//        set { _GutenbergRawPremiumEntityId = value; }
//    }

//    private long _GutenbergrawUnpaidEntityId;
//    public long GutenbergrawUnpaidEntityId
//    {
//        get { return _GutenbergrawUnpaidEntityId; }
//        set { _GutenbergrawUnpaidEntityId = value; }
//    }

//    private string? _GutenbergRawPremiumEntityIdList;
//    public string? GutenbergRawPremiumEntityIdList
//    {
//        get { return _GutenbergRawPremiumEntityIdList; }
//        set { _GutenbergRawPremiumEntityIdList = value; }
//    }

//    private long _PremiumTransactionCodeKey;
//    public long PremiumTransactionCodeKey
//    {
//        get { return _PremiumTransactionCodeKey; }
//        set { _PremiumTransactionCodeKey = value; }
//    }

//    private string? _GutenbergRawPremiumManualEntityIdList;
//    public string? GutenbergRawPremiumManualEntityIdList
//    {
//        get { return _GutenbergRawPremiumManualEntityIdList; }
//        set { _GutenbergRawPremiumManualEntityIdList = value; }
//    }

//    private string? _GutenbergUnpaidPremiumEntityIdList;
//    public string? GutenbergUnpaidPremiumEntityIdList
//    {
//        get { return _GutenbergUnpaidPremiumEntityIdList; }
//        set { _GutenbergUnpaidPremiumEntityIdList = value; }
//    }

//    private long _GutenbergEntityId;
//    public long GutenbergEntityId
//    {
//        get { return _GutenbergEntityId; }
//        set { _GutenbergEntityId = value; }
//    }

//    private string? _GutenbergUnearnedEntityIdList;
//    public string? GutenbergUnearnedEntityIdList
//    {
//        get { return _GutenbergUnearnedEntityIdList; }
//        set { _GutenbergUnearnedEntityIdList = value; }
//    }

//    private string? _RSCTransactionID;
//    public string? RSCTransactionID
//    {
//        get { return _RSCTransactionID; }
//        set { _RSCTransactionID = value; }
//    }

//    private DateTime? _RowInsertDate;
//    public DateTime? RowInsertDate
//    {
//        get { return _RowInsertDate; }
//        set { _RowInsertDate = value; }
//    }

//    private DateTime? _RowUpdateDate;
//    public DateTime? RowUpdateDate
//    {
//        get { return _RowUpdateDate; }
//        set { _RowUpdateDate = value; }
//    }

//    private long _RowInsertLogId;
//    public long RowInsertLogId
//    {
//        get { return _RowInsertLogId; }
//        set { _RowInsertLogId = value; }
//    }

//    private long _RowUpdateLogId;
//    public long RowUpdateLogId
//    {
//        get { return _RowUpdateLogId; }
//        set { _RowUpdateLogId = value; }
//    }

//    private string? _RowInsertUsername;
//    public string? RowInsertUsername
//    {
//        get { return _RowInsertUsername; }
//        set { _RowInsertUsername = value; }
//    }

//    private string? _RowUpdateUsername;
//    public string? RowUpdateUsername
//    {
//        get { return _RowUpdateUsername; }
//        set { _RowUpdateUsername = value; }
//    }

//    private string? _RowIsCurrent;
//    public string? RowIsCurrent
//    {
//        get { return _RowIsCurrent; }
//        set { _RowIsCurrent = value; }
//    }

//    private DateTime? _RowEffectiveDate;
//    public DateTime? RowEffectiveDate
//    {
//        get { return _RowEffectiveDate; }
//        set { _RowEffectiveDate = value; }
//    }

//    private DateTime? _RowExpirationDate;
//    public DateTime? RowExpirationDate
//    {
//        get { return _RowExpirationDate; }
//        set { _RowExpirationDate = value; }
//    }

//    private string? _RowStatus;
//    public string? RowStatus
//    {
//        get { return _RowStatus; }
//        set { _RowStatus = value; }
//    }


//    public GrossPremiumDTO(long GrossPremiumKey_, 
//                           long AccountingPeriodKey_, 
//                           DateTime? PremiumDueStartDate_, 
//                           long ResidentStateKey_, 
//                           long CoverageCodeKey_, 
//                           DateTime? PremiumDueEndDate_, 
//                           decimal? CollectedPremiumAmount_, 
//                           long PolicyrenewalKey_, 
//                           long SourceSystemXrefKey_, 
//                           long CompanyKey_, 
//                           decimal? EarnedPremiumAmount_, 
//                           long ManagementProgramKey_, 
//                           decimal? WrittenPremiumAmount_, 
//                           decimal? UnearnedPremiumAmount_, 
//                           decimal? UnpaidPremiumAmount_, 
//                           int? CollectedNumberOfInsured_, 
//                           decimal? BrokerPercent_, 
//                           DateTime? ActivityDate_, 
//                           decimal? AdminPercent_,
//                           int? EarnedNumberOfInsured_, 
//                           decimal? SourceCollectedNetPremiumAmount_, 
//                           int? WrittenNumberOfInsured_, 
//                           int? UnearnedNumberOfInsured_, 
//                           int? UnpaidNumberOfInsured_, 
//                           string? TPACode_, 
//                           DateTime? InvoiceDate_, 
//                           long GutenbergGrossPremiumEntityId_, 
//                           DateTime? GutenbergStartTs_, 
//                           long GutenbergGrossPremiumManualEntityId_, 
//                           long GutenbergPolicyEntityID_, 
//                           long GutenbergRawPremiumEntityId_, 
//                           long GutenbergrawUnpaidEntityId_, 
//                           string? GutenbergRawPremiumEntityIdList_, 
//                           long PremiumTransactionCodeKey_, 
//                           string? GutenbergRawPremiumManualEntityIdList_, 
//                           string? GutenbergUnpaidPremiumEntityIdList_, 
//                           long GutenbergEntityId_, 
//                           string? GutenbergUnearnedEntityIdList_, 
//                           string? RSCTransactionID_, 
//                           DateTime? RowInsertDate_, 
//                           DateTime? RowUpdateDate_, 
//                           long RowInsertLogId_, 
//                           long RowUpdateLogId_, 
//                           string? RowInsertUsername_, 
//                           string? RowUpdateUsername_, 
//                           string? RowIsCurrent_, 
//                           DateTime? RowEffectiveDate_, 
//                           DateTime? RowExpirationDate_, 
//                           string? RowStatus_)
//    {
//        this.GrossPremiumKey = GrossPremiumKey_;
//        this.AccountingPeriodKey = AccountingPeriodKey_;
//        this.PremiumDueStartDate = PremiumDueStartDate_;
//        this.ResidentStateKey = ResidentStateKey_;
//        this.CoverageCodeKey = CoverageCodeKey_;
//        this.PremiumDueEndDate = PremiumDueEndDate_;
//        this.CollectedPremiumAmount = CollectedPremiumAmount_;
//        this.PolicyrenewalKey = PolicyrenewalKey_;
//        this.SourceSystemXrefKey = SourceSystemXrefKey_;
//        this.CompanyKey = CompanyKey_;
//        this.EarnedPremiumAmount = EarnedPremiumAmount_;
//        this.ManagementProgramKey = ManagementProgramKey_;
//        this.WrittenPremiumAmount = WrittenPremiumAmount_;
//        this.UnearnedPremiumAmount = UnearnedPremiumAmount_;
//        this.UnpaidPremiumAmount = UnpaidPremiumAmount_;
//        this.CollectedNumberOfInsured = CollectedNumberOfInsured_;
//        this.BrokerPercent = BrokerPercent_;
//        this.ActivityDate = ActivityDate_;
//        this.AdminPercent = AdminPercent_;
//        this.EarnedNumberOfInsured = EarnedNumberOfInsured_;
//        this.SourceCollectedNetPremiumAmount = SourceCollectedNetPremiumAmount_;
//        this.WrittenNumberOfInsured = WrittenNumberOfInsured_;
//        this.UnearnedNumberOfInsured = UnearnedNumberOfInsured_;
//        this.UnpaidNumberOfInsured = UnpaidNumberOfInsured_;
//        this.TPACode = TPACode_;
//        this.InvoiceDate = InvoiceDate_;
//        this.GutenbergGrossPremiumEntityId = GutenbergGrossPremiumEntityId_;
//        this.GutenbergStartTs = GutenbergStartTs_;
//        this.GutenbergGrossPremiumManualEntityId = GutenbergGrossPremiumManualEntityId_;
//        this.GutenbergPolicyEntityID = GutenbergPolicyEntityID_;
//        this.GutenbergRawPremiumEntityId = GutenbergRawPremiumEntityId_;
//        this.GutenbergrawUnpaidEntityId = GutenbergrawUnpaidEntityId_;
//        this.GutenbergRawPremiumEntityIdList = GutenbergRawPremiumEntityIdList_;
//        this.PremiumTransactionCodeKey = PremiumTransactionCodeKey_;
//        this.GutenbergRawPremiumManualEntityIdList = GutenbergRawPremiumManualEntityIdList_;
//        this.GutenbergUnpaidPremiumEntityIdList = GutenbergUnpaidPremiumEntityIdList_;
//        this.GutenbergEntityId = GutenbergEntityId_;
//        this.GutenbergUnearnedEntityIdList = GutenbergUnearnedEntityIdList_;
//        this.RSCTransactionID = RSCTransactionID_;
//        this.RowInsertDate = RowInsertDate_;
//        this.RowUpdateDate = RowUpdateDate_;
//        this.RowInsertLogId = RowInsertLogId_;
//        this.RowUpdateLogId = RowUpdateLogId_;
//        this.RowInsertUsername = RowInsertUsername_;
//        this.RowUpdateUsername = RowUpdateUsername_;
//        this.RowIsCurrent = RowIsCurrent_;
//        this.RowEffectiveDate = RowEffectiveDate_;
//        this.RowExpirationDate = RowExpirationDate_;
//        this.RowStatus = RowStatus_;
//    }
//}