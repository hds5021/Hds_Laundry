using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    /// <summary>
    /// This is common for all type of Request class . 
    /// Add new Request class if require
    /// </summary>
    //public class customerRequest
    //{
    //    public int CustomerNumber { get; set; }
    //    public string CustomerName { get; set; }
    //}

    /// Customer Table Class

    public class customerRequest
    {
        public Int32 CustomerID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string CustomerName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public string Contact { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
        // public int CustomerNumber { get; set; }
    }


    /// <summary>
    ///  Customer Branch Class
    /// </summary>
    public class customerBranchRequest
    {
        public Int32 CustomerBranchID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 CustomerID { get; set; }
        public string BranchName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string ContactPerson { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///Employee Master Class
    ///</summary>

    public class clsEmployeeMaster
    {
        public Int32 Empid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string EmpAdd { get; set; }
        public string EmpMobile { get; set; }
        public string EmpPhoneno { get; set; }
        public string EmpemailId { get; set; }
        public string civilno { get; set; }
        public string IsRetired { get; set; }
        public string IsDeleted { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///Expense_Mst
    ///</summary>

    public class clsExpense_Mst
    {
        public Int32 ExpenseItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public string ItemName { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    /// expenses
    /// </summary>
    ///

    public class clsexpenses
    {
        public Int32 ExpenseID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public Int32 ExpenseItemID { get; set; }
        public Int32 ItemId { get; set; }
        public decimal Amount { get; set; }
        public string Details { get; set; }
        public Int32 PaidBy { get; set; }
        public Int32 PartyId { get; set; }
        public DateTime BillDate { get; set; }
        public Int32 IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///groups
    /// </summary>

    public class clsgroups
    {
        public Int32 GroupID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string ColorCode { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    /// <summary>
    /// instance_Settings
    /// </summary>

    public class clsinstanceSettings
    {
        public Int32 InstanceID { get; set; }
        public string Tax1Name { get; set; }
        public decimal Tax1Value { get; set; }
        public string Tax2Name { get; set; }
        public decimal Tax2Value { get; set; }
        public string Tax3Name { get; set; }
        public decimal Tax3Value { get; set; }
        public Int32 BillNoReset { get; set; }
        public string EmailFrom { get; set; }
        public string Password { get; set; }
        public Int32 InstanceLogo { get; set; }
        public Int32 PosBillPrintLogo { get; set; }
        public string PosBillPrintHoliday { get; set; }
        public Int32 PosDeliveryDays { get; set; }
        public Int32 PosItemOrder { get; set; }
        public Int32 PosItemLocalNameDisplay { get; set; }
        public Int32 PosItemLocalNameBillPrint { get; set; }
        public string CountryCode { get; set; }
        public string MobileNo { get; set; }
        public string AccountSID { get; set; }
        public string AuthToken { get; set; }
        public decimal HangerRate { get; set; }
        public string MessageEndOfBill { get; set; }
        public string TnCEnglish { get; set; }
        public string TnCLocalLanguage { get; set; }
        public Int32 ItemwiseReportLocalLanguage { get; set; }
        public decimal MaxDiscountPercentage { get; set; }
    }

    ///<summary>
    ///instances
    /// </summary>
    /// 

    public class clsinstances
    {
        public Int32 InstanceID { get; set; } public string InstanceName { get; set; } public string Telephone { get; set; } public string MobileNo { get; set; } public string Version { get; set; } public string Logo { get; set; } public DateTime LastUpdateDateTime { get; set; } public DateTime LastBackupDate { get; set; } public DateTime LastRestoreDate { get; set; } public DateTime LastRestoreUpto { get; set; } public DateTime LastResetDate { get; set; } public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///item_price
    /// </summary>
    /// 
    public class clsitemPrice
    {
        public Int32 ItemPriceID { get; set; }
        public Int32 ItemID { get; set; }
        public Int32 GroupID { get; set; }
        public decimal Price { get; set; }
    }

    ///<summary>
    ///items
    /// </summary>
    /// 
    public class clsitems
    {
        public Int32 ItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 CustomerID { get; set; }
        public string ItemName { get; set; }
        public string ItemLocalName { get; set; }
        public string PriceRate { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///MenuMaster
    /// </summary>
    /// 
    public class clsMenuMaster
    {
        public Int32 Menuid { get; set; }
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///ModuleMaster
    /// </summary>
    public class clsModuleMaster
    {
        public Int32 Moduleid { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDesc { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///officeBranch
    /// </summary>
    public class clsofficeBranch
    {
        public Int32 OfficeBranchID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string BranchName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///officeBranchSales
    /// </summary>
    public class clsofficeBanchSales
    {
        public Int32 BranchSalesID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public decimal Amount { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///PageMaster
    /// </summary>
    public class clsPageMaster
    {
        public Int32 Pageid { get; set; }
        public string PageName { get; set; }
        public string PageDesc { get; set; }
        public Int32 Moduleid { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///Party
    /// </summary>
    public class clsParty
    {
        public Int32 PartyID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string PartyName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///pos
    /// </summary>
    public class clspos
    {
        public Int32 PosID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 BillNo { get; set; }
        public Int32 CustomerID { get; set; }
        public Int32 CustomerBranchID { get; set; }
        public string Type { get; set; }
        public Int32 TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPayable { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal ReturnAmount { get; set; }
        public Int32 IsPaid { get; set; }
        public Int32 PaidBy { get; set; }
        public string PaymentDateTime { get; set; }
        public Int32 Status { get; set; }
        public string Comment { get; set; }
        public Int32 HangerQuantity { get; set; }
        public decimal HangerRate { get; set; }
        public decimal HangerAmount { get; set; }
        public string IsClothCollected { get; set; }
        public Int32 IsCarpetInvoice { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Int32 IsDeleted { get; set; }
        public string DeletedDateTime { get; set; }
        public string CreatedDate { get; set; }
    }

    ///<summary>
    ///posItems
    /// </summary>
    public class clsposItems
    {
        public Int32 PosItemID { get; set; }
        public Int32 PosID { get; set; }
        public Int32 ItemID { get; set; }
        public Int32 GroupID { get; set; }
        public decimal ItemWidth { get; set; }
        public decimal ItemLength { get; set; }
        public string PriceRate { get; set; }
        public decimal Price { get; set; }
        public Int32 Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }

    ///<summary>
    ///posbillcount
    /// </summary>
    public class clsposbillcount
    {
        public Int32 PosBillCountID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 TotalBills { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///PreSubMenu
    /// </summary>
    public class clsPreSubMenu
    {
        public Int32 Presubmenuid { get; set; }
        public string PresubmenuName { get; set; }
        public string PresubmenuDesc { get; set; }
        public Int32 Menuid { get; set; }
        public Int32 Submenuid { get; set; }
        public string Status { get; set; }
    }


    ///<summary>
    ///purchaseInvoice
    /// </summary>
    public class clspurchaseInvoice
    {
        public Int32 InvoiceID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public string BranchName { get; set; }
        public Int32 SupplierID { get; set; }
        public string Contact { get; set; }
        public Int32 TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string Type { get; set; }
        public string Narration { get; set; }
        public string QuotationNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int32 IsDeleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///purchaseInvoiceItems
    /// </summary>
    public class clspurchaseInvoiceItems
    {
        public Int32 InvoiceItemID { get; set; }
        public Int32 InvoiceID { get; set; }
        public Int32 PurchaseItemID { get; set; }
        public Int32 Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }

    ///<summary>
    ///purchaseInvoiceMaster
    /// </summary>
    public class clspurchaseItemsMaster
    {
        public Int32 PurchaseItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string ItemName { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///RollMaster
    /// </summary>
    public class clsRollMaster
    {
        public Int32 Rollid { get; set; }
        public string RollName { get; set; }
        public string RollDesc { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///smslogs
    /// </summary>
    public class clssmslogs
    {
        public Int32 SmsLogID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 CustomerID { get; set; }
        public Int32 SmsID { get; set; }
        public string TemplateName { get; set; }
        public string CountryCode { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///smsTemplates
    /// </summary>
    public class clssmsTemplates
    {
        public Int32 SmsID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string TemplateName { get; set; }
        public string Details { get; set; }
        public Int32 Ismart_sms_language { get; set; }
    }

    ///<summary>
    ///SubMenuMaster
    /// </summary>
    public class clsSubMenuMaster
    {
        public Int32 Submenuid { get; set; }
        public string SubmenuName { get; set; }
        public string SubmenuDesc { get; set; }
        public Int32 Menuid { get; set; }
        public string Status { get; set; }
    }

    ///<summary>
    ///suppliers
    /// </summary>
    public class clssuppliers
    {
        public Int32 SupplierID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string SupplierName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public string Contact { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    ///<summary>
    ///UserMaster
    /// </summary>
    public class clsUserMaster
    {
        public Int32 Userid { get; set; }
        public string Umusername { get; set; }
        public string Umpassword { get; set; }
        public Int32 Empid { get; set; }
        public Int32 Rollid { get; set; }
        public string RollLocation { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsRetired { get; set; }
        public bool IsDeleted { get; set; }
        public string InsertedBy { get; set; }
        public string CreatedBy { get; set; }
        public string DeleteBy { get; set; }
        public string ViewedBy { get; set; }
        public string Status { get; set; }
    }
    ///<summary>
    ///UserRightsMaster
    /// </summary>
    public class clsUserRightsMaster
    {
        public Int32 Urid { get; set; }
        public Int32 Userid { get; set; }
        public Int32 Moduleid { get; set; }
        public Int32 Rollid { get; set; }
        public Int32 Pageid { get; set; }
        public Int32 Empid { get; set; }
        public bool IsDelete { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSearch { get; set; }
        public bool IsAdd { get; set; }
        public bool IsReport { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ApplyDate { get; set; }
        public string CreatedBy { get; set; }
        public string Updatedby { get; set; }
        public string Deletedid { get; set; }
        public string Status { get; set; }
    }
