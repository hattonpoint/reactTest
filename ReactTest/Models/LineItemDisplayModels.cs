using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactTest.Models
{
    public class LineItemsDisplay
    {
        public List<PackageItemDisplay> Packages { get; set; }
        public List<PackageItemDisplay> DeclinedPackages { get; set; }
    }

    public class PackageItemDisplay
    {
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public bool IsAPackage { get; set; }
        public string PackageOpCode { get; set; }
        public int? PackageQuantity { get; set; }
        public decimal PackagePartSubtotal { get; set; }
        public decimal PackageOtherChargeSubtotal { get; set; }
        public decimal PackageLaborSubtotal { get; set; }

        public int PackageSortOrder { get; set; }

        public int? PackageSequence { get; set; }
        public bool Declined { get; set; }

        public List<PartItemDisplay> PartItems { get; set; }

        public decimal PackageTotal
        {
            get { return PartItems.Sum(p => p.PartAndLaborSubtotal); }
        }

        public bool IsOPComplete
        {
            get { return (PartItems != null && PartItems.Any(p => p.IsOPComplete) ? true : false); }
        }
    }

    public class PartItemDisplay
    {
        public int CompanyID { get; set; }
        public int ShopNumber { get; set; }
        public int TicketNumber { get; set; }
        public int Sequence { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public decimal Quantity { get; set; }
        public decimal PartPrice { get; set; }
        public decimal PartLabor { get; set; }
        public decimal PartOtherCharge { get; set; }
        public decimal PartSubtotal { get; set; }
        public decimal LaborSubtotal { get; set; }
        public decimal PartAndLaborSubtotal { get; set; }
        public int PackageSortOrder { get; set; }
        public int PackageItemSortOrder { get; set; }
        public bool Declined { get; set; }

        public decimal PartDiscountAmount { get; set; }
        public decimal PartDiscountPercent { get; set; }

        public string PartDiscountType
        {
            get { return (PartDiscountAmount > 0 ? "amount" : "percent"); }
        }

        public decimal LaborDiscountAmount { get; set; }
        public decimal LaborDiscountPercent { get; set; }

        public string LaborDiscountType
        {
            get { return (LaborDiscountAmount > 0 ? "amount" : "percent"); }
        }

        public bool IsOutsidePurchase { get; set; }
        public string OPInvoiceNumber { get; set; }
        public string OPSupplierName { get; set; }
        public decimal? OPQuantityReceived { get; set; }
        public string OPPartNumber { get; set; }
        public decimal? OPCost { get; set; }
        public int OPSupplierNumber { get; set; }
        public string OPPurchaseOrderNumber { get; set; }
        public decimal? OPCore { get; set; }
        public DateTime? OPQuantityReceivedLastUpdated { get; set; }
        public bool IsOPComplete { get; set; }
        public bool HasWarranty { get; set; }
        public string WarrantyReasonCode { get; set; }
        public int WarrantyReasonCodeNumber { get; set; }
        public string OriginalInvoiceNumber { get; set; }
        public DateTime? OriginalInvoiceDate { get; set; }
        public string WarrantyStampName { get; set; }
        public int WarrantyStampNumber { get; set; }
        public int ExtraData1Type { get; set; }
        public string ExtraData1 { get; set; }
        public int? TicketLineItemTypeNumber { get; set; }
        public string TicketLineItemTypeName { get; set; }
        public bool HasTicketLineItemType { get; set; }
        public int? EmployeeID { get; set; }
        public decimal? HoursPaid { get; set; }
        public decimal? HoursWorked { get; set; }
    }

    public class TicketLineItemDisplay
    {
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public bool IsAPackage { get; set; }
        public string PackageOpCode { get; set; }
        public int? PackageQuantity { get; set; }
        public int Sequence { get; set; }
        public int? PackageSequence { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public decimal QuantityPerPackage { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal PartPrice { get; set; }
        public decimal PartLabor { get; set; }
        public decimal PartOtherCharge { get; set; }
        public decimal PartSubtotal { get; set; }
        public decimal LaborSubtotal { get; set; }
        public decimal DiscountedPartAndLaborSubtotal { get; set; }
        public int PackageSortOrder { get; set; }
        public int PackageItemSortOrder { get; set; }

        public decimal PartDiscountAmount { get; set; }
        public decimal PartDiscountPercent { get; set; }
        public decimal LaborDiscountAmount { get; set; }
        public decimal LaborDiscountPercent { get; set; }

        public bool IsOutsidePurchase { get; set; }
        public string OPInvoiceNumber { get; set; }
        public string OPSupplierName { get; set; }
        public decimal? OPQuantityReceived { get; set; }
        public string OPPartNumber { get; set; }
        public decimal? OPCost { get; set; }
        public int OPSupplierNumber { get; set; }
        public string OPPurchaseOrderNumber { get; set; }
        public decimal? OPCore { get; set; }
        public DateTime? OPQuantityReceivedLastUpdated { get; set; }
        public string OriginalInvoiceNumber { get; set; }
        public DateTime? OriginalInvoiceDate { get; set; }
        public string WarrantyReasonCode { get; set; }
        public int WarrantyReasonCodeNumber { get; set; }
        public bool HasWarranty { get; set; }

        public string WarrantyStampName { get; set; }
        public int WarrantyStampNumber { get; set; }
        public int ExtraData1Type { get; set; }
        public string ExtraData1 { get; set; }
        public int? TicketLineItemTypeNumber { get; set; }
        public string TicketLineItemTypeName { get; set; }
        public bool HasTicketLineItemType { get; set; }

        public int? EmployeeID { get; set; }
        public decimal? HoursPaid { get; set; }
        public decimal? ActualHoursWorked { get; set; }
        public bool Declined { get; set; }
    }
}