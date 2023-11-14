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

  [HttpGet("{id}")]
  public ActionResult GetExtract(int id){
    Extract extract = extracts.Find(x => x.Id == id);
    if(extract == null) {
      return NotFound();
    }
    return Ok(extract);
  }

  [HttpPost]
  public ActionResult PostExtract([FromBody]Extract extract){
    extracts.Add(extract);
    return Created("", extract);
  }

  [HttpDelete("{id}")]
  public ActionResult DeleteExtract(int id){
    Extract extract = extracts.Find(x => x.Id == id);
    if(extract == null) {
      return NotFound();
    }
    extracts.Remove(extract);
    // return Ok(extracts);
    return NoContent();
  }

  [HttpPut("{id}")]
  public ActionResult UpdateExtract(int id, [FromBody] Extract extract){
    Extract existingExtract = extracts.Find(x => x.Id == id);
    if(existingExtract == null) {
      return NotFound();
    }

    existingExtract.Description = extract.Description;
    existingExtract.Date = extract.Date;
    existingExtract.Value = extract.Value;
    existingExtract.Loose = extract.Loose;
    existingExtract.Status = extract.Status;
    return Ok(existingExtract);
  }
}