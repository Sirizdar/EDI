using Microsoft.AspNetCore.Mvc;
using Mockup.datamodels;

namespace Mockup.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class apiUserController : ControllerBase
    {
        private readonly db_userContext db;

        public apiUserController(db_userContext _db)
        {
            this.db = _db;
        }

        [HttpGet("GetAllData")]
        public List<TblUser> GetAllData()
        {
            List<TblUser> data = db.TblUsers.Where(a => a.Userid != null).ToList();
            return data;
        }

        [HttpDelete("Delete/{id}")]
        public ActionResult<TblUser> Delete(int id)
        {
            TblUser userToDelete = db.TblUsers.FirstOrDefault(a => a.Userid == id);

            if (userToDelete == null)
            {
                return NotFound();
            }

            db.TblUsers.Remove(userToDelete);
            db.SaveChanges();

            return Ok(userToDelete);
        }
    }
}
