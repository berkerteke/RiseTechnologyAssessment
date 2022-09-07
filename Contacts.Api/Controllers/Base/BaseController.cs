using System.Collections;
using System.Net;
using Contacts.Application.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class BaseController : ControllerBase
{
    protected async Task<ActionResult> Execute<T>(BaseApiResponse<T> response)
    {
        if (response.Data is null)
        {
            response.StatusCode = (int)HttpStatusCode.NotFound;
            response.Succeeded = true;
            if (string.IsNullOrEmpty(response.Message)) response.Message = "Not Found!";
            return NotFound(response);
        }
        if (response.Data.GetType().GUID == typeof(List<>).GUID)
        {
            if (response.Data is IList { Count: 0 })
                return NoContent();
        }
          

        if (string.IsNullOrEmpty(response.Message)) response.Message = "Success";
        response.Succeeded = true;
        response.StatusCode = (int)HttpStatusCode.OK;
        return Ok(response);
    }
}