using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace simples.Controllers;

[Route("api/[controller]")]
[ApiController]
public class K8sController : ControllerBase
{
  private readonly IFeatureManager _featureManager;
  public K8sController (IFeatureManager featureManager)
  {
      _featureManager = featureManager;
  }
  
  [HttpGet("BooleanFilter")]
  public async Task<IActionResult> BooleanFilter()
  {
      if (await _featureManager.IsEnabledAsync("BooleanFilter"))
      {
          return Ok("Feature enabled");
      }
      else
      {
          return BadRequest("Feature not enabled");
      }
  }
}