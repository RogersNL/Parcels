using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/Parcels")]
    public ActionResult Index()
    {
      ParcelObject newParcel = new ParcelObject(Request.Query["length"],Request.Query["width"],Request.Query["height"],Request.Query["weight"]);
      newParcel.Save();

      return View(ParcelObject.GetAll());
    }
  }
}
