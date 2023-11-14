using Microsoft.AspNetCore.Mvc;
using bankStatement;

[ApiController]
[Route("api/[controller]")]
public class ExtractController : ControllerBase {
  private static List<Extract> extracts = new List<Extract>();

[HttpGet]
  public ActionResult GetExtract(){
    return Ok(extracts);
  }
}