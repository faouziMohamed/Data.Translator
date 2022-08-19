using System.Diagnostics;
using km.Translate.Data.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace km.Translate.Api.Controllers;

public class MetaController : BaseApiController
{
  public MetaController(IUnitOfWork unitOfWork) : base(unitOfWork)
  {
  }
  [HttpGet("/info")]
  public ActionResult<string> Info()
  {
    var assembly = typeof(WebMarker).Assembly;
    var creationDate = System.IO.File.GetCreationTime(assembly.Location);
    string? version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
    return Ok($"Version: {version}, Last Updated: {creationDate}");
  }
}