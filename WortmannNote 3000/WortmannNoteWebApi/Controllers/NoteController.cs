using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WortmannNoteWebApi.Business;
using WortmannNoteWebApi.Models;

namespace WortmannNoteWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private NoteHelper _noteHelper;
        private WortmannNoteContext _context;
        public NoteController(NoteHelper noteHelper, WortmannNoteContext noteContext)
        {
            _noteHelper = noteHelper;
            _context = noteContext;
        }
        [HttpPost]
        public ActionResult NewNote(NotePostModel data)
        {
            try
            {
                _noteHelper.NewNote(data.Name, data.Header, data.Content);
                return Ok();

            }
            catch (Exception ex)
            {
                return this.BadRequest(ex);
            }
        }
        [HttpGet]
        public ActionResult<NoteModel[]> Get()
        {
            return Ok(_context.Notes.ToArray());
        }
    }

    public class NotePostModel
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
    }
}
