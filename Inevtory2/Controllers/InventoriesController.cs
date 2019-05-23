using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inevtory2.Models;

namespace Inevtory2.Controllers
{
    public class InventoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        // GET: Inventories
        public ActionResult Index()
        {
            var mainInventory = db.MainInventory
                .Include(i => i.DEPARTMENT).Include(i => i.EQUIPMENT).Include(i => i.LOCATION)
                .Include(i => i.MANUFACTURER).Include(i => i.MODEL).Include(i => i.STATUS);
            return View(mainInventory.ToList());
        }

        [Authorize]
        // GET: Inventories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.MainInventory
                .Include(i => i.DEPARTMENT).Include(i => i.EQUIPMENT).Include(i => i.LOCATION)
                .Include(i => i.MANUFACTURER).Include(i => i.MODEL).Include(i => i.STATUS)
                .SingleOrDefault(n=>n.InventoryId==id);

            if (inventory == null)
            {
                return HttpNotFound();
            }
            return View(inventory);
        }

        [Authorize]
        // GET: Inventories/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "departmentname");
            ViewBag.EquipmentId = new SelectList(db.Equipment, "Id", "equipmentname");
            ViewBag.LocationId = new SelectList(db.Location, "Id", "locationname");
            ViewBag.ManufacturerId = new SelectList(db.Manufacturer, "Id", "manufacturername");
            ViewBag.ModelId = new SelectList(db.Model, "Id", "modelname");
            ViewBag.StatusId = new SelectList(db.Dtatus, "Id", "statusname");
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InventoryId,EquipmentId,ManufacturerId,ModelId,SerialNo,DateOfPuchaseId,LocationId,StatusId,DepartmentId")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                db.MainInventory.Add(inventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "departmentname", inventory.DepartmentId);
            ViewBag.EquipmentId = new SelectList(db.Equipment, "Id", "equipmentname", inventory.EquipmentId);
            ViewBag.LocationId = new SelectList(db.Location, "Id", "locationname", inventory.LocationId);
            ViewBag.ManufacturerId = new SelectList(db.Manufacturer, "Id", "manufacturername", inventory.ManufacturerId);
            ViewBag.ModelId = new SelectList(db.Model, "Id", "modelname", inventory.ModelId);
            ViewBag.StatusId = new SelectList(db.Dtatus, "Id", "statusname", inventory.StatusId);
            return View(inventory);
        }


        [Authorize]
        // GET: Inventories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.MainInventory.Find(id);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "departmentname", inventory.DepartmentId);
            ViewBag.EquipmentId = new SelectList(db.Equipment, "Id", "equipmentname", inventory.EquipmentId);
            ViewBag.LocationId = new SelectList(db.Location, "Id", "locationname", inventory.LocationId);
            ViewBag.ManufacturerId = new SelectList(db.Manufacturer, "Id", "manufacturername", inventory.ManufacturerId);
            ViewBag.ModelId = new SelectList(db.Model, "Id", "modelname", inventory.ModelId);
            ViewBag.StatusId = new SelectList(db.Dtatus, "Id", "statusname", inventory.StatusId);
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InventoryId,EquipmentId,ManufacturerId,ModelId,SerialNo,DateOfPuchaseId,LocationId,StatusId,DepartmentId")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "departmentname", inventory.DepartmentId);
            ViewBag.EquipmentId = new SelectList(db.Equipment, "Id", "equipmentname", inventory.EquipmentId);
            ViewBag.LocationId = new SelectList(db.Location, "Id", "locationname", inventory.LocationId);
            ViewBag.ManufacturerId = new SelectList(db.Manufacturer, "Id", "manufacturername", inventory.ManufacturerId);
            ViewBag.ModelId = new SelectList(db.Model, "Id", "modelname", inventory.ModelId);
            ViewBag.StatusId = new SelectList(db.Dtatus, "Id", "statusname", inventory.StatusId);
            return View(inventory);
        }

        [Authorize]
        // GET: Inventories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.MainInventory

                .Include(i => i.DEPARTMENT).Include(i => i.EQUIPMENT).Include(i => i.LOCATION)
                .Include(i => i.MANUFACTURER).Include(i => i.MODEL).Include(i => i.STATUS)
                .SingleOrDefault(n => n.InventoryId == id);

            if (inventory == null)
            {
                return HttpNotFound();
            }
            return View(inventory);
        }


        [Authorize]
        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventory inventory = db.MainInventory.Find(id);
            db.MainInventory.Remove(inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
