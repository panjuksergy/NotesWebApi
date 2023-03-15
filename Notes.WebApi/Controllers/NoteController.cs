using Microsoft.AspNetCore.Mvc;
using Notes.Application.Notes.Queries
namespace Notes.WebApi.Controllers;

public class NoteController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<NoteListVm>> GetAll()
    {
        
    }
}