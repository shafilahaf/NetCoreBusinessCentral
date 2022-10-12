using AspNetCore.Reporting;
using Dummy_BC_Diagnos_MVC_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dummy_BC_Diagnos_MVC_2.Controllers
{
	public class ReportSalesController : Controller
	{
		private readonly DemoDiagnoseBC200Context _context;

		public ReportSalesController(DemoDiagnoseBC200Context context)
		{
			this._context = context;
		}

		public async Task<IActionResult> PrintReportSO(string? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var so = await _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.FirstOrDefaultAsync(m => m.No == id);
			
			if (so == null)
			{
				return NotFound();
			}

			var dt = new DataTable();
			dt = getData(so.No);

			string mimetype = "";
			int extension = 1;
			var path = @"Reports/ReportSalesHeader.rdlc";

			Dictionary<string, string> param = new Dictionary<string, string>();
			//param.Add("pic", itemPic);
			
			LocalReport lr = new LocalReport(path);
			lr.AddDataSource("DataSetSalesHeader", dt);
			lr.AddDataSource("DataSetSalesLine", dt);
			lr.AddDataSource("DataSetImgItem", dt);

			var result = lr.Execute(RenderType.Pdf, extension, param, mimetype);
			return File(result.MainStream, "application/pdf");

		}

		private DataTable getData(string no)
		{
			var dt = new DataTable();
			dt.Columns.AddRange(new DataColumn[16]
			{
				new DataColumn("No_"), new DataColumn("Sell_to_Customer_Name_"), new DataColumn("Order_Date", typeof(DateTime)),
				new DataColumn("Document_No_"), new DataColumn("Line_No_"), new DataColumn("Sell_to_Customer_No_"), new DataColumn("Type"),
				new DataColumn("NoLine_"), new DataColumn("Description"), new DataColumn("Unit_of_Measure"), new DataColumn("Quantity"),
				new DataColumn("UnitPrice"),new DataColumn("Unit_of_Measure_Code"), new DataColumn("No"), new DataColumn("DescriptionImg"),
				new DataColumn("Picture")
			});

			DataRow dr = dt.NewRow();

			//sales header
			var sHeader = _context.CronusAustraliaPtyLtdSalesHeader437dbf0e84ff417a965dEd2bb9650972.FirstOrDefault(m => m.No == no);
			dr["No_"] = sHeader.No;
			dr["Order_Date"] = sHeader.OrderDate.ToString();
			dr["Sell_to_Customer_Name_"] = sHeader.SellToCustomerName;

			//sales lines
			var sLines = _context.CronusAustraliaPtyLtdSalesLine437dbf0e84ff417a965dEd2bb9650972s.Where(m => m.DocumentNo == no);
			foreach (var sLine in sLines)
			{
				dr["Document_No_"] = sLine.DocumentNo;
				dr["Line_No_"] = sLine.LineNo;
				dr["Sell_to_Customer_No_"] = sLine.SellToCustomerNo;
				dr["Type"] = sLine.Type;
				dr["NoLine_"] = sLine.No;
				dr["Description"] = sLine.Description;
				dr["Unit_of_Measure"] = sLine.UnitOfMeasure;
				dr["Quantity"] = string.Format("{0:0}", sLine.Quantity);
				dr["UnitPrice"] = string.Format("{0:0}", sLine.UnitPrice);
				dr["Unit_of_Measure_Code"] = sLine.UnitOfMeasureCode;

				//cek dari table picture berdasarkan item no.
				var itemPic = _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.Where(x => x.No == sLine.No).FirstOrDefault();
				if (itemPic != null)
				{
					dr["No"] = itemPic.No;
					dr["DescriptionImg"] = itemPic.Description;
					dr["Picture"] = Convert.ToBase64String(itemPic.Picture);
					dt.Rows.Add(dr.ItemArray);
				}
				

				dt.Rows.Add(dr.ItemArray);
				
			}

			dt.Rows.Add(dr);
			return dt;


		}
	}
}
