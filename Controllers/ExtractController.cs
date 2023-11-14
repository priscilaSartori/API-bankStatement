using Microsoft.AspNetCore.Mvc;
using bankStatement;
using System;

[ApiController]
[Route("api/[controller]")]
public class ExtractController : ControllerBase {
  private static List<Extract> extracts = new List<Extract>();

  [HttpGet]
  public ActionResult GetAllExtract()
  {
    try
      {
        return Ok(extracts);
      }
        catch (Exception ex)
      {
        return StatusCode(500, "Erro interno do servidor");
      }
  }

  [HttpGet("{id}")]
  public ActionResult GetExtractById(int id)
  {
    try
      {
        Extract extract = extracts.Find(x => x.Id == id);
          if (extract == null)
          {
            return NotFound();
          }
        return Ok(extract);
      }
      catch (Exception ex)
      {
        return StatusCode(500, "Erro interno do servidor");
      }  
  }

  [HttpPost]
  public ActionResult PostExtract([FromBody]Extract extract)
  {
    try
      {
        if (extract == null || !ModelState.IsValid)
          {
            return BadRequest("Dados inválidos");
          }

        extracts.Add(extract);
        return CreatedAtAction(nameof(GetExtractById), new { id = extract.Id }, extract);
      }
      catch (Exception ex)
      {
        return StatusCode(500, "Erro interno do servidor");
      } 
  }

  [HttpDelete("{id}")]
  public ActionResult DeleteExtract(int id)
  {
    try
      {
        Extract extract = extracts.Find(x => x.Id == id);
          if (extract == null)
          {
            return NotFound();
          }

          extracts.Remove(extract);
          return NoContent();
      }
        catch (Exception ex)
      {
        return StatusCode(500, "Erro interno do servidor");
      }  
  }

  [HttpPut("{id}")]
  public ActionResult UpdateExtractById(int id, [FromBody] Extract extract)
  {
    try
      {
        Extract existingExtract = extracts.Find(x => x.Id == id);
          if (existingExtract == null)
          {
            return NotFound();
          }

          existingExtract.Description = extract.Description;
          existingExtract.Date = extract.Date;
          existingExtract.Value = extract.Value;
          existingExtract.Loose = extract.Loose;
          existingExtract.Status = extract.Status;

          return Ok(existingExtract);
      }
        catch (Exception ex)
      {
        return StatusCode(500, "Erro interno do servidor");
      }
  }
}