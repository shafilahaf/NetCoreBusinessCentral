using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dummy_BC_Diagnos_MVC_2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Dummy_BC_Diagnos_MVC_2.Controllers
{
    public class ItemPicController : Controller
    {
        private readonly DemoDiagnoseBC200Context _context;

        public ItemPicController(DemoDiagnoseBC200Context context)
        {
            _context = context;
        }

        // GET: ItemPic
        public async Task<IActionResult> Index()
        {
            return View(await _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.ToListAsync());
        }

        // GET: ItemPic/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d = await _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds
                .FirstOrDefaultAsync(m => m.No == id);
            if (cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d == null)
            {
                return NotFound();
            }

            return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
        }

        // GET: ItemPic/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemPic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Timestamp,No,Description,Picture,SystemId,SystemCreatedAt,SystemCreatedBy,SystemModifiedAt,SystemModifiedBy")] CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d, IFormFile image1)
        {
            if (ModelState.IsValid)
            {
                if (image1 != null && image1.Length != 0)
                {
                    if (image1.Length > 1057152)
                    {
                        ViewBag.ImageError = "Please upload jpg/jpeg/png/gif image of upto 1 mb size only";
                        return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
                    }
                    else
                    {
                        using var ms = new MemoryStream();
                        image1.CopyTo(ms);
                        cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d.Picture = ms.ToArray();
                    }
                }

                _context.Add(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
        }

        // GET: ItemPic/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d = await _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.FindAsync(id);
            if (cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d == null)
            {
                return NotFound();
            }
            return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
        }

        // POST: ItemPic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Timestamp,No,Description,Picture,SystemId,SystemCreatedAt,SystemCreatedBy,SystemModifiedAt,SystemModifiedBy")] CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d)
        {
            if (id != cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d.No)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098dExists(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d.No))
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
            return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
        }

        // GET: ItemPic/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d = await _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds
                .FirstOrDefaultAsync(m => m.No == id);
            if (cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d == null)
            {
                return NotFound();
            }

            return View(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
        }

        // POST: ItemPic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d = await _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.FindAsync(id);
            _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.Remove(cronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098d);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098dExists(string id)
        {
            return _context.CronusAustraliaPtyLtdItemPic47466c52Add14a8cA9ccDaa9c554098ds.Any(e => e.No == id);
        }

        
    }
}
