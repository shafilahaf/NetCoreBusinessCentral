using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dummy_BC_Diagnos_MVC_2.Models
{
    public partial class DemoDiagnoseBC200Context : DbContext
    {
        public DemoDiagnoseBC200Context()
        {
        }

        public DemoDiagnoseBC200Context(DbContextOptions<DemoDiagnoseBC200Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972> CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 { get; set; }
        public virtual DbSet<CronusAustraliaPtyLtdSalesLine437dbf0e84ff417a965dEd2bb9650972> CronusAustraliaPtyLtdSalesLine437dbf0e84ff417a965dEd2bb9650972s { get; set; }
        public virtual DbSet<CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d> CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Demo Diagnose BC (20-0);Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;Integrated Security=True;Encrypt=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_100_CI_AS");

            modelBuilder.Entity<CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No })
                    .HasName("CRONUS Australia Pty_ Ltd_$Sales Header$437dbf0e-84ff-417a-965d-ed2bb9650972$Key1");

                entity.ToTable("CRONUS Australia Pty_ Ltd_$Sales Header$437dbf0e-84ff-417a-965d-ed2bb9650972");

                entity.HasIndex(e => new { e.DocumentDate, e.DocumentType, e.No }, "$Key10")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShipmentDate, e.Status, e.LocationCode, e.ResponsibilityCenter, e.DocumentType, e.No }, "$Key11")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalespersonCode, e.DocumentType, e.No }, "$Key12")
                    .IsUnique();

                entity.HasIndex(e => new { e.SystemModifiedAt, e.DocumentType, e.No }, "$Key13")
                    .IsUnique();

                entity.HasIndex(e => new { e.No, e.DocumentType }, "$Key2")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToCustomerNo, e.No }, "$Key3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BillToCustomerNo, e.No }, "$Key4")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.CombineShipments, e.BillToCustomerNo, e.CurrencyCode, e.Eu3PartyTrade, e.DimensionSetId, e.JournalTemplName, e.No }, "$Key5")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.ExternalDocumentNo, e.DocumentType, e.No }, "$Key6")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToContactNo, e.No }, "$Key7")
                    .IsUnique();

                entity.HasIndex(e => new { e.BillToContactNo, e.DocumentType, e.No }, "$Key8")
                    .IsUnique();

                entity.HasIndex(e => new { e.IncomingDocumentEntryNo, e.DocumentType, e.No }, "$Key9")
                    .IsUnique();

                entity.HasIndex(e => e.SystemId, "CRONUS Australia Pty_ Ltd_$Sales Header$437dbf0e-84ff-417a-965d-ed2bb9650972$$systemId")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .HasColumnName("No_");

                entity.Property(e => e.AdjustmentAppliesTo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Adjustment Applies-to")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.AppliesToId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Applies-to ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Assigned User ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bal_ Account No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BasAdjustment).HasColumnName("BAS Adjustment");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Bill-to Address")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bill-to Address 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Bill-to City")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Bill-to Contact")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to Contact No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Bill-to County")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to Customer No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCustomerTemplCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to Customer Templ_ Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToCustomerTemplateCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Bill-to Customer Template Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToIcPartnerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to IC Partner Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Bill-to Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bill-to Name 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to Post Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Campaign No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CombineShipments).HasColumnName("Combine Shipments");

                entity.Property(e => e.CompanyBankAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Company Bank Account Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompressPrepayment).HasColumnName("Compress Prepayment");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Currency Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Currency Factor");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Customer Disc_ Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Customer Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer Price Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DirectDebitMandateId)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("Direct Debit Mandate ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DocNoOccurrence).HasColumnName("Doc_ No_ Occurrence");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Document Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Due Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Exit Point")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("External Document No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GetShipmentUsed).HasColumnName("Get Shipment Used");

                entity.Property(e => e.IcDirection).HasColumnName("IC Direction");

                entity.Property(e => e.IcStatus).HasColumnName("IC Status");

                entity.Property(e => e.IncomingDocumentEntryNo).HasColumnName("Incoming Document Entry No_");

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Invoice Disc_ Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InvoiceDiscountCalculation).HasColumnName("Invoice Discount Calculation");

                entity.Property(e => e.InvoiceDiscountValue)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Invoice Discount Value");

                entity.Property(e => e.JobQueueEntryId).HasColumnName("Job Queue Entry ID");

                entity.Property(e => e.JobQueueStatus).HasColumnName("Job Queue Status");

                entity.Property(e => e.JournalTemplName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Journal Templ_ Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Language Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastPostingNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Last Posting No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastPrepaymentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Last Prepayment No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastPrepmtCrMemoNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Last Prepmt_ Cr_ Memo No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastReturnReceiptNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Last Return Receipt No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastShippingNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Last Shipping No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Location Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("On Hold")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OpportunityNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Opportunity No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OrderClass)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Order Class")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackageTrackingNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Package Tracking No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Payment Discount _");

                entity.Property(e => e.PaymentInstructionsId).HasColumnName("Payment Instructions Id");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Payment Method Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PaymentServiceSetId).HasColumnName("Payment Service Set ID");

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Payment Terms Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pmt_ Discount Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PostedTaxDocument).HasColumnName("Posted Tax Document");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Posting Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Posting Description")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PostingFromWhseRef).HasColumnName("Posting from Whse_ Ref_");

                entity.Property(e => e.PostingNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Posting No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PostingNoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Posting No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Prepayment)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepayment _");

                entity.Property(e => e.PrepaymentDueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Prepayment Due Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PrepaymentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepayment No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepaymentNoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepayment No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepmtCrMemoNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepmt_ Cr_ Memo No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepmt_ Cr_ Memo No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepmtPaymentDiscount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Payment Discount _");

                entity.Property(e => e.PrepmtPaymentTermsCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Prepmt_ Payment Terms Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepmtPmtDiscountDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Prepmt_ Pmt_ Discount Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PrepmtPostingDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Prepmt_ Posting Description")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PriceCalculationMethod).HasColumnName("Price Calculation Method");

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PrintPostedDocuments).HasColumnName("Print Posted Documents");

                entity.Property(e => e.PrintedTaxDocument).HasColumnName("Printed Tax Document");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Promised Delivery Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.QuoteAccepted).HasColumnName("Quote Accepted");

                entity.Property(e => e.QuoteAcceptedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Quote Accepted Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Quote No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.QuoteSentToCustomer)
                    .HasColumnType("datetime")
                    .HasColumnName("Quote Sent to Customer")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.QuoteValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Quote Valid Until Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reason Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Requested Delivery Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Responsibility Center")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReturnReceiptNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Return Receipt No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReturnReceiptNoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Return Receipt No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Salesperson Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Sell-to Address")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToAddress2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Sell-to Address 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Sell-to City")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToContact)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Sell-to Contact")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to Contact No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Sell-to Country_Region Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCounty)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Sell-to County")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Sell-to Customer Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCustomerName2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Sell-to Customer Name 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to Customer No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCustomerTemplCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to Customer Templ_ Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToCustomerTemplateCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Sell-to Customer Template Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToEMail)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("Sell-to E-Mail")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToIcPartnerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to IC Partner Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToPhoneNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Sell-to Phone No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SellToPostCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to Post Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SendIcDocument).HasColumnName("Send IC Document");

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ship-to Address")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ship-to Address 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Ship-to City")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ship-to Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ship-to Contact")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Ship-to County")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ship-to Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ship-to Name 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ship-to Post Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipment Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Shipment Method Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Shipping Agent Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Shipping Agent Service Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shipping No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingNoSeries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shipping No_ Series")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Shipping Time")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SystemCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemCreatedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");

                entity.Property(e => e.SystemId)
                    .HasColumnName("$systemId")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SystemModifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemModifiedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Tax Area Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxDocumentMarked).HasColumnName("Tax Document Marked");

                entity.Property(e => e.TaxDocumentType).HasColumnName("Tax Document Type");

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp");

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Specification")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transport Method")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("VAT Base Discount _");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("VAT Country_Region Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Registration No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhtAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("WHT Amount");

                entity.Property(e => e.WhtBusinessPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WHT Business Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WorkDescription)
                    .HasColumnType("image")
                    .HasColumnName("Work Description");

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("Your Reference")
                    .HasDefaultValueSql("(N'')");
            });
            modelBuilder.Entity<CronusAustraliaPtyLtdSalesLine437dbf0e84ff417a965dEd2bb9650972>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("CRONUS Australia Pty_ Ltd_$Sales Line$437dbf0e-84ff-417a-965d-ed2bb9650972$Key1");

                entity.ToTable("CRONUS Australia Pty_ Ltd_$Sales Line$437dbf0e-84ff-417a-965d-ed2bb9650972");

                entity.HasIndex(e => new { e.DocumentType, e.SellToCustomerNo, e.ShipmentNo, e.DocumentNo, e.LineNo }, "$Key11")
                    .IsUnique();

                entity.HasIndex(e => new { e.JobContractEntryNo, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key12")
                    .IsUnique();

                entity.HasIndex(e => new { e.RecalculateInvoiceDisc, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key15")
                    .IsUnique();

                entity.HasIndex(e => new { e.QtyShippedNotInvoiced, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key16")
                    .IsUnique();

                entity.HasIndex(e => new { e.QtyShippedBase, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key17")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShipmentDate, e.OutstandingQuantity, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key18")
                    .IsUnique();

                entity.HasIndex(e => new { e.SystemModifiedAt, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key19")
                    .IsUnique();

                entity.HasIndex(e => new { e.CompletelyShipped, e.DocumentType, e.DocumentNo, e.LineNo }, "$Key20")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.Type, e.No, e.VariantCode, e.DropShipment, e.LocationCode, e.ShipmentDate, e.DocumentNo, e.LineNo }, "$Key3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BillToCustomerNo, e.CurrencyCode, e.DocumentNo, e.LineNo }, "$Key4")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo }, "$Key7")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.ShipmentNo, e.ShipmentLineNo, e.DocumentNo, e.LineNo }, "$Key9")
                    .IsUnique();

                entity.HasIndex(e => e.SystemId, "CRONUS Australia Pty_ Ltd_$Sales Line$437dbf0e-84ff-417a-965d-ed2bb9650972$$systemId")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .HasColumnName("Document No_");

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowItemChargeAssignment).HasColumnName("Allow Item Charge Assignment");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Amount Including VAT");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bill-to Customer No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Bin Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Blanket Order No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BomItemNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BOM Item No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompletelyShipped).HasColumnName("Completely Shipped");

                entity.Property(e => e.CopiedFromPostedDoc).HasColumnName("Copied From Posted Doc_");

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Cross-Reference No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Cross-Reference Type No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Currency Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Customer Disc_ Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer Price Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DeferralCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Deferral Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Depreciation Book Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Description 2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DropShipment).HasColumnName("Drop Shipment");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Exit Point")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FaPostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FA Posting Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GrossWeight)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Gross Weight");

                entity.Property(e => e.IcItemReferenceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IC Item Reference No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IC Partner Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IcPartnerRefType).HasColumnName("IC Partner Ref_ Type");

                entity.Property(e => e.IcPartnerReference)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IC Partner Reference")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InvDiscAmountToInvoice)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Inv_ Disc_ Amount to Invoice");

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Inv_ Discount Amount");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Item Category Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemReferenceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Item Reference No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemReferenceType).HasColumnName("Item Reference Type");

                entity.Property(e => e.ItemReferenceTypeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Item Reference Type No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemReferenceUnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Item Reference Unit of Measure")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.JobContractEntryNo).HasColumnName("Job Contract Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Job No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Job Task No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LineAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Line Amount");

                entity.Property(e => e.LineDiscount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Line Discount _");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Line Discount Amount");

                entity.Property(e => e.LineDiscountCalculation).HasColumnName("Line Discount Calculation");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Location Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NetWeight)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Net Weight");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginallyOrderedNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Originally Ordered No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Originally Ordered Var_ Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OutOfStockSubstitution).HasColumnName("Out-of-Stock Substitution");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutstandingAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Outstanding Amount");

                entity.Property(e => e.OutstandingAmountLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Outstanding Amount (LCY)");

                entity.Property(e => e.OutstandingQtyBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Outstanding Qty_ (Base)");

                entity.Property(e => e.OutstandingQuantity)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Outstanding Quantity");

                entity.Property(e => e.PlannedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Planned Delivery Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PlannedShipmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Planned Shipment Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PmtDiscountAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Pmt_ Discount Amount");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Prepayment)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepayment _");

                entity.Property(e => e.PrepaymentAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepayment Amount");

                entity.Property(e => e.PrepaymentLine).HasColumnName("Prepayment Line");

                entity.Property(e => e.PrepaymentTaxAreaCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepayment Tax Area Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepaymentTaxGroupCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepayment Tax Group Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepaymentTaxLiable).HasColumnName("Prepayment Tax Liable");

                entity.Property(e => e.PrepaymentVat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepayment VAT _");

                entity.Property(e => e.PrepaymentVatDifference)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepayment VAT Difference");

                entity.Property(e => e.PrepaymentVatIdentifier)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prepayment VAT Identifier")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrepmtAmountInvInclVat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Amount Inv_ Incl_ VAT");

                entity.Property(e => e.PrepmtAmountInvLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Amount Inv_ (LCY)");

                entity.Property(e => e.PrepmtAmtDeducted)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt Amt Deducted");

                entity.Property(e => e.PrepmtAmtInclVat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Amt_ Incl_ VAT");

                entity.Property(e => e.PrepmtAmtInv)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Amt_ Inv_");

                entity.Property(e => e.PrepmtAmtToDeduct)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt Amt to Deduct");

                entity.Property(e => e.PrepmtLineAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Line Amount");

                entity.Property(e => e.PrepmtPmtDiscountAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ Pmt_ Discount Amount");

                entity.Property(e => e.PrepmtVatAmountDeducted)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ VAT Amount Deducted");

                entity.Property(e => e.PrepmtVatAmountInvLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ VAT Amount Inv_ (LCY)");

                entity.Property(e => e.PrepmtVatBaseAmt)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ VAT Base Amt_");

                entity.Property(e => e.PrepmtVatBaseDeducted)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt_ VAT Base Deducted");

                entity.Property(e => e.PrepmtVatCalcType).HasColumnName("Prepmt_ VAT Calc_ Type");

                entity.Property(e => e.PrepmtVatDiffDeducted)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt VAT Diff_ Deducted");

                entity.Property(e => e.PrepmtVatDiffToDeduct)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Prepmt VAT Diff_ to Deduct");

                entity.Property(e => e.PriceCalculationMethod).HasColumnName("Price Calculation Method");

                entity.Property(e => e.PriceDescription)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("Price description")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Product Group Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Profit)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Profit _");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Promised Delivery Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.PurchOrderLineNo).HasColumnName("Purch_ Order Line No_");

                entity.Property(e => e.PurchaseOrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Purchase Order No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Purchasing Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Invoiced (Base)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ per Unit of Measure");

                entity.Property(e => e.QtyRoundingPrecision)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Rounding Precision");

                entity.Property(e => e.QtyRoundingPrecisionBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Rounding Precision (Base)");

                entity.Property(e => e.QtyShippedBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Shipped (Base)");

                entity.Property(e => e.QtyShippedNotInvdBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Shipped Not Invd_ (Base)");

                entity.Property(e => e.QtyShippedNotInvoiced)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ Shipped Not Invoiced");

                entity.Property(e => e.QtyToAsmToOrderBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Asm_ to Order (Base)");

                entity.Property(e => e.QtyToAssembleToOrder)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Assemble to Order");

                entity.Property(e => e.QtyToInvoice)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Invoice");

                entity.Property(e => e.QtyToInvoiceBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Invoice (Base)");

                entity.Property(e => e.QtyToShip)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Ship");

                entity.Property(e => e.QtyToShipBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Qty_ to Ship (Base)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Quantity (Base)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Quantity Invoiced");

                entity.Property(e => e.QuantityShipped)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Quantity Shipped");

                entity.Property(e => e.RecalculateInvoiceDisc).HasColumnName("Recalculate Invoice Disc_");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Requested Delivery Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Responsibility Center")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RetQtyRcdNotInvdBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Ret_ Qty_ Rcd_ Not Invd_(Base)");

                entity.Property(e => e.ReturnQtyRcdNotInvd)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Qty_ Rcd_ Not Invd_");

                entity.Property(e => e.ReturnQtyReceived)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Qty_ Received");

                entity.Property(e => e.ReturnQtyReceivedBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Qty_ Received (Base)");

                entity.Property(e => e.ReturnQtyToReceive)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Qty_ to Receive");

                entity.Property(e => e.ReturnQtyToReceiveBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Qty_ to Receive (Base)");

                entity.Property(e => e.ReturnRcdNotInvd)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Rcd_ Not Invd_");

                entity.Property(e => e.ReturnRcdNotInvdLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Return Rcd_ Not Invd_ (LCY)");

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Return Reason Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReturnReceiptLineNo).HasColumnName("Return Receipt Line No_");

                entity.Property(e => e.ReturnReceiptNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Return Receipt No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReturnsDeferralStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Returns Deferral Start Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Sell-to Customer No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipment Date")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.ShipmentLineNo).HasColumnName("Shipment Line No_");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shipment No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippedNotInvLcyNoVat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Shipped Not Inv_ (LCY) No VAT");

                entity.Property(e => e.ShippedNotInvoiced)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Shipped Not Invoiced");

                entity.Property(e => e.ShippedNotInvoicedLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Shipped Not Invoiced (LCY)");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Shipping Agent Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Shipping Agent Service Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Shipping Time")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SpecialOrder).HasColumnName("Special Order");

                entity.Property(e => e.SpecialOrderPurchLineNo).HasColumnName("Special Order Purch_ Line No_");

                entity.Property(e => e.SpecialOrderPurchaseNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Special Order Purchase No_")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SystemCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemCreatedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");

                entity.Property(e => e.SystemCreatedEntry).HasColumnName("System-Created Entry");

                entity.Property(e => e.SystemId)
                    .HasColumnName("$systemId")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SystemModifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemModifiedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Tax Area Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Tax Category")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Tax Group Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp");

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Specification")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Transport Method")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Unit Cost");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Unit Cost (LCY)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Unit of Measure")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Unit of Measure Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Unit Price");

                entity.Property(e => e.UnitVolume)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Unit Volume");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("Units per Parcel");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Variant Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("VAT _");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("VAT Base Amount");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatClauseCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Clause Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatDifference)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("VAT Difference");

                entity.Property(e => e.VatIdentifier)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Identifier")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhtAbsorbBase)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("WHT Absorb Base");

                entity.Property(e => e.WhtBusinessPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WHT Business Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhtProductPostingGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WHT Product Posting Group")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Work Type Code")
                    .HasDefaultValueSql("(N'')");
            });
            modelBuilder.Entity<CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("CRONUS Australia Pty_ Ltd_$ItemPic$47466c52-add1-4a8c-a9cc-daa9c554098d$PK");

                entity.ToTable("CRONUS Australia Pty_ Ltd_$ItemPic$47466c52-add1-4a8c-a9cc-daa9c554098d");

                entity.HasIndex(e => e.SystemId, "CRONUS Australia Pty_ Ltd_$ItemPic$47466c52-add1-4a8c-a9cc-daa9c554098d$$systemId")
                    .IsUnique();

                entity.Property(e => e.No).HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.SystemCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemCreatedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");

                entity.Property(e => e.SystemId)
                    .HasColumnName("$systemId")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SystemModifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("$systemModifiedAt")
                    .HasDefaultValueSql("('1753.01.01')");

                entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp");
            });

            modelBuilder.HasSequence("$SEQ$NumberSequence$03E354A8-BC37-4BC7-A948-27A00AC2ACAB$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$1591179C-C838-459A-BA85-DC96A85FC8F2$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$19387BA3-3E2A-4153-B252-CECD97FA88BD$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$196A1F6E-9CBF-43D1-A484-438ECFE0C2AA$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$217E3738-47AC-4769-B0B7-98415730C313$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$28175378-ECC3-4FA9-ACE6-AB8073BC413B$CRONUS Australia Pty_ Ltd_").StartsAt(-1);

            modelBuilder.HasSequence("$SEQ$NumberSequence$2A786525-B13B-410B-BF99-F4C493559727$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$2EC72B34-9CD5-442D-ADA7-983D1E249CA3$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$396D10C3-6EF3-48B9-9225-88EA3F4B1B9E$CRONUS Australia Pty_ Ltd_").StartsAt(101001);

            modelBuilder.HasSequence("$SEQ$NumberSequence$3AFDE91F-E4F7-4286-92EF-EA3C3E089DA0$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$3C02D555-5F4D-4096-9C8F-103AFF51A5B0$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$3F073026-12BC-4918-A4C3-F7CED221C46F$CRONUS Australia Pty_ Ltd_").StartsAt(-1);

            modelBuilder.HasSequence("$SEQ$NumberSequence$3F10C4EE-2DEE-41D8-830E-CA3C52A0ED72$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$4B544BB7-8F8A-4429-8AE2-611542CE5B08$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$4FDCB3D5-65C2-470E-91D7-AEBD8A157D84$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$595EDE6A-62BC-4EAC-ADAD-E8FC2E7F515C$CRONUS Australia Pty_ Ltd_").StartsAt(-1);

            modelBuilder.HasSequence("$SEQ$NumberSequence$5EBDCD5F-27CE-43D4-8FCE-0C247DF84B15$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$69F00466-AF8D-4337-9F20-CAAD73C90BBA$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$6DC359D2-7A1C-433A-B936-4F811F7A6935$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$71890FCF-7897-4FC4-9C09-E5AA7E78AD3C$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$7720277B-F675-4500-AD2A-77234CF84823$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$7B92F553-8DAF-40BF-A0D8-0E164F9A53D7$CRONUS Australia Pty_ Ltd_").StartsAt(-1);

            modelBuilder.HasSequence("$SEQ$NumberSequence$892F844E-FEB0-430D-9084-7767D74DC6DC$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$8F5C5580-55AE-45F3-AEC3-2831F568340E$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$922971A5-A2B3-4B73-95E1-564740DB2C23$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$96CC161E-959B-4BFB-8885-B84D909EAA2F$CRONUS Australia Pty_ Ltd_").StartsAt(-1);

            modelBuilder.HasSequence("$SEQ$NumberSequence$9A51CB47-4F21-43FD-936D-77C25389A495$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$9CF86FCF-F869-4C3A-A254-EF4D6817C15A$CRONUS Australia Pty_ Ltd_").StartsAt(1001);

            modelBuilder.HasSequence("$SEQ$NumberSequence$A12E7371-418C-410A-8C08-09AFC8EC0997$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$A809D1CB-364E-4577-A5AC-1F1FE916FD00$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$A8F2513A-7D78-40A8-B627-C9EFD8896063$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$AFD226D3-42AE-4DE5-8869-D8747B4F6E93$CRONUS Australia Pty_ Ltd_").StartsAt(70103);

            modelBuilder.HasSequence("$SEQ$NumberSequence$BAE537AF-0240-4ABF-9B2C-F6E8F0DE9BA0$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$C06BFDFA-AFDA-4F8F-B2FA-ED9B2F2D0A5A$CRONUS Australia Pty_ Ltd_").StartsAt(1001);

            modelBuilder.HasSequence("$SEQ$NumberSequence$C180E345-B3C4-45C9-97BC-D16391440F19$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$C1DAB482-95C0-400E-836E-222B121534D8$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$C76C2856-CFE6-4D2F-89DC-1952F7F5E780$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$C9B3E059-23B3-40F0-AF70-F3AABA241CA2$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$CAB95061-EF15-4A85-A0D8-333665C7D74D$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$CB1471F8-921F-4DD3-993A-6248C8B231AA$CRONUS Australia Pty_ Ltd_")
                .StartsAt(1988)
                .IncrementsBy(4);

            modelBuilder.HasSequence("$SEQ$NumberSequence$D6B566E7-63DB-4DF5-9BAE-076085BD9610$CRONUS Australia Pty_ Ltd_")
                .StartsAt(80)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$DC2EDAD7-1A8B-4042-B728-1C0DC6125A75$CRONUS Australia Pty_ Ltd_").StartsAt(70200);

            modelBuilder.HasSequence("$SEQ$NumberSequence$E22BA0CC-4FBD-4666-9507-A904FA47EAFD$CRONUS Australia Pty_ Ltd_")
                .StartsAt(30)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$E6458F15-A6D6-416B-95E8-718A60EA65C4$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$E681E37B-A49D-4B5E-8518-3EC6B9063117$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$E7D7680C-A383-4636-ADF6-EAAF8DCD5F98$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$EA7F976D-BC5A-46E0-A001-E1C6BE6C875B$CRONUS Australia Pty_ Ltd_")
                .StartsAt(1996)
                .IncrementsBy(4);

            modelBuilder.HasSequence("$SEQ$NumberSequence$F0836618-41CE-4B57-AD5F-5A7C05516231$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$F45269AD-24E3-4CA9-9B0F-07023E6E6582$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            modelBuilder.HasSequence("$SEQ$NumberSequence$F65D5509-4511-4E70-AD2E-31048DCDE972$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$F7E72229-58E2-4577-9547-7BE2DB5B7A31$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$F8C45FC8-196E-41B3-85C1-E693AB9E69B3$CRONUS Australia Pty_ Ltd_");

            modelBuilder.HasSequence("$SEQ$NumberSequence$FD6B18F5-10E6-4187-BA5E-1700724646E8$CRONUS Australia Pty_ Ltd_")
                .StartsAt(10)
                .IncrementsBy(10);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
