using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dummy_BC_Diagnos_MVC_2.Models;

namespace Dummy_BC_Diagnos_MVC_2.Controllers
{
    public class SalesHeaderController : Controller
    {
        private readonly DemoDiagnoseBC200Context _context;

        public SalesHeaderController(DemoDiagnoseBC200Context context)
        {
            _context = context;
        }

        // GET: SalesHeader
        public async Task<IActionResult> Index()
        {
            return View(await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.ToListAsync());
        }

        // GET: SalesHeader/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 = await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972
                .FirstOrDefaultAsync(m => m.DocumentType == id);
            if (cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 == null)
            {
                return NotFound();
            }

            return View(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
        }

        // GET: SalesHeader/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesHeader/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Timestamp,DocumentType,No,SellToCustomerNo,BillToCustomerNo,BillToName,BillToName2,BillToAddress,BillToAddress2,BillToCity,BillToContact,YourReference,ShipToCode,ShipToName,ShipToName2,ShipToAddress,ShipToAddress2,ShipToCity,ShipToContact,OrderDate,PostingDate,ShipmentDate,PostingDescription,PaymentTermsCode,DueDate,PaymentDiscount,PmtDiscountDate,ShipmentMethodCode,LocationCode,ShortcutDimension1Code,ShortcutDimension2Code,CustomerPostingGroup,CurrencyCode,CurrencyFactor,CustomerPriceGroup,PricesIncludingVat,InvoiceDiscCode,CustomerDiscGroup,LanguageCode,SalespersonCode,OrderClass,NoPrinted,OnHold,AppliesToDocType,AppliesToDocNo,BalAccountNo,Ship,Invoice,PrintPostedDocuments,ShippingNo,PostingNo,LastShippingNo,LastPostingNo,PrepaymentNo,LastPrepaymentNo,PrepmtCrMemoNo,LastPrepmtCrMemoNo,VatRegistrationNo,CombineShipments,ReasonCode,GenBusPostingGroup,Eu3PartyTrade,TransactionType,TransportMethod,VatCountryRegionCode,SellToCustomerName,SellToCustomerName2,SellToAddress,SellToAddress2,SellToCity,SellToContact,BillToPostCode,BillToCounty,BillToCountryRegionCode,SellToPostCode,SellToCounty,SellToCountryRegionCode,ShipToPostCode,ShipToCounty,ShipToCountryRegionCode,BalAccountType,ExitPoint,Correction,DocumentDate,ExternalDocumentNo,Area,TransactionSpecification,PaymentMethodCode,ShippingAgentCode,PackageTrackingNo,NoSeries,PostingNoSeries,ShippingNoSeries,TaxAreaCode,TaxLiable,VatBusPostingGroup,Reserve,AppliesToId,VatBaseDiscount,Status,InvoiceDiscountCalculation,InvoiceDiscountValue,SendIcDocument,IcStatus,SellToIcPartnerCode,BillToIcPartnerCode,IcDirection,Prepayment,PrepaymentNoSeries,CompressPrepayment,PrepaymentDueDate,PrepmtCrMemoNoSeries,PrepmtPostingDescription,PrepmtPmtDiscountDate,PrepmtPaymentTermsCode,PrepmtPaymentDiscount,QuoteNo,QuoteValidUntilDate,QuoteSentToCustomer,QuoteAccepted,QuoteAcceptedDate,JobQueueStatus,JobQueueEntryId,CompanyBankAccountCode,IncomingDocumentEntryNo,IsTest,SellToPhoneNo,SellToEMail,PaymentInstructionsId,JournalTemplName,WorkDescription,DimensionSetId,PaymentServiceSetId,DirectDebitMandateId,DocNoOccurrence,CampaignNo,SellToCustomerTemplateCode,SellToContactNo,BillToContactNo,BillToCustomerTemplateCode,OpportunityNo,SellToCustomerTemplCode,BillToCustomerTemplCode,ResponsibilityCenter,ShippingAdvice,PostingFromWhseRef,RequestedDeliveryDate,PromisedDeliveryDate,ShippingTime,OutboundWhseHandlingTime,ShippingAgentServiceCode,Receive,ReturnReceiptNo,ReturnReceiptNoSeries,LastReturnReceiptNo,PriceCalculationMethod,AllowLineDisc,GetShipmentUsed,Id,AssignedUserId,Adjustment,BasAdjustment,AdjustmentAppliesTo,WhtBusinessPostingGroup,WhtAmount,TaxDocumentType,PrintedTaxDocument,PostedTaxDocument,TaxDocumentMarked,SystemId,SystemCreatedAt,SystemCreatedBy,SystemModifiedAt,SystemModifiedBy")] CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
        }

        // GET: SalesHeader/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 = await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.FindAsync(id);
            if (cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 == null)
            {
                return NotFound();
            }
            return View(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
        }

        // POST: SalesHeader/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Timestamp,DocumentType,No,SellToCustomerNo,BillToCustomerNo,BillToName,BillToName2,BillToAddress,BillToAddress2,BillToCity,BillToContact,YourReference,ShipToCode,ShipToName,ShipToName2,ShipToAddress,ShipToAddress2,ShipToCity,ShipToContact,OrderDate,PostingDate,ShipmentDate,PostingDescription,PaymentTermsCode,DueDate,PaymentDiscount,PmtDiscountDate,ShipmentMethodCode,LocationCode,ShortcutDimension1Code,ShortcutDimension2Code,CustomerPostingGroup,CurrencyCode,CurrencyFactor,CustomerPriceGroup,PricesIncludingVat,InvoiceDiscCode,CustomerDiscGroup,LanguageCode,SalespersonCode,OrderClass,NoPrinted,OnHold,AppliesToDocType,AppliesToDocNo,BalAccountNo,Ship,Invoice,PrintPostedDocuments,ShippingNo,PostingNo,LastShippingNo,LastPostingNo,PrepaymentNo,LastPrepaymentNo,PrepmtCrMemoNo,LastPrepmtCrMemoNo,VatRegistrationNo,CombineShipments,ReasonCode,GenBusPostingGroup,Eu3PartyTrade,TransactionType,TransportMethod,VatCountryRegionCode,SellToCustomerName,SellToCustomerName2,SellToAddress,SellToAddress2,SellToCity,SellToContact,BillToPostCode,BillToCounty,BillToCountryRegionCode,SellToPostCode,SellToCounty,SellToCountryRegionCode,ShipToPostCode,ShipToCounty,ShipToCountryRegionCode,BalAccountType,ExitPoint,Correction,DocumentDate,ExternalDocumentNo,Area,TransactionSpecification,PaymentMethodCode,ShippingAgentCode,PackageTrackingNo,NoSeries,PostingNoSeries,ShippingNoSeries,TaxAreaCode,TaxLiable,VatBusPostingGroup,Reserve,AppliesToId,VatBaseDiscount,Status,InvoiceDiscountCalculation,InvoiceDiscountValue,SendIcDocument,IcStatus,SellToIcPartnerCode,BillToIcPartnerCode,IcDirection,Prepayment,PrepaymentNoSeries,CompressPrepayment,PrepaymentDueDate,PrepmtCrMemoNoSeries,PrepmtPostingDescription,PrepmtPmtDiscountDate,PrepmtPaymentTermsCode,PrepmtPaymentDiscount,QuoteNo,QuoteValidUntilDate,QuoteSentToCustomer,QuoteAccepted,QuoteAcceptedDate,JobQueueStatus,JobQueueEntryId,CompanyBankAccountCode,IncomingDocumentEntryNo,IsTest,SellToPhoneNo,SellToEMail,PaymentInstructionsId,JournalTemplName,WorkDescription,DimensionSetId,PaymentServiceSetId,DirectDebitMandateId,DocNoOccurrence,CampaignNo,SellToCustomerTemplateCode,SellToContactNo,BillToContactNo,BillToCustomerTemplateCode,OpportunityNo,SellToCustomerTemplCode,BillToCustomerTemplCode,ResponsibilityCenter,ShippingAdvice,PostingFromWhseRef,RequestedDeliveryDate,PromisedDeliveryDate,ShippingTime,OutboundWhseHandlingTime,ShippingAgentServiceCode,Receive,ReturnReceiptNo,ReturnReceiptNoSeries,LastReturnReceiptNo,PriceCalculationMethod,AllowLineDisc,GetShipmentUsed,Id,AssignedUserId,Adjustment,BasAdjustment,AdjustmentAppliesTo,WhtBusinessPostingGroup,WhtAmount,TaxDocumentType,PrintedTaxDocument,PostedTaxDocument,TaxDocumentMarked,SystemId,SystemCreatedAt,SystemCreatedBy,SystemModifiedAt,SystemModifiedBy")] CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972)
        {
            if (id != cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.DocumentType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972Exists(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.DocumentType))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
        }

        // GET: SalesHeader/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 = await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972
                .FirstOrDefaultAsync(m => m.DocumentType == id);
            if (cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 == null)
            {
                return NotFound();
            }

            return View(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
        }

        // POST: SalesHeader/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972 = await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.FindAsync(id);
            _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.Remove(cronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972Exists(int id)
        {
            return _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.Any(e => e.DocumentType == id);
        }
    }
}
