using Contacts.Application.Dto.Common;
using Contacts.Application.Dto.Request;
using Contacts.Application.Dto.Response;
using Contacts.Application.Service.Contact.Interface;
using Contacts.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers;

public class ContactController : BaseController
{
    private readonly IContactSvc _contactSvc;

    public ContactController(IContactSvc contactSvc)
    {
        _contactSvc = contactSvc;
    }

    [HttpPost]
    public async Task<ActionResult<bool>> Create([FromBody] ContactReqDto dto)
    {
        return await Execute(await _contactSvc.CreateContact(dto));
    }

    [HttpDelete]
    public async Task<ActionResult<bool>> Delete([FromBody] GuidReqDto guid)
    {
        return await Execute(await _contactSvc.DeleteContact(guid.Id));
    }
    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<ContactResDto>>> GetAll()
    {
        return await Execute(await _contactSvc.GetAllContacts());
    }
    [HttpGet("{Id:guid}")]
    public async Task<ActionResult<IEnumerable<ContactResDto>>> GetContactById([From]Guid id)
    {
        return await Execute(await _contactSvc.GetContactById(id));
    }

    [HttpPost("ContactDetail")]
    public async Task<ActionResult<bool>> AddContactDetail([FromBody] ContactDetailReqDto dto)
    {
        return await Execute(await _contactSvc.AddContactDetail(dto));
    }
    [HttpDelete("ContactDetail/{Id:guid}")]
    public async Task<ActionResult<bool>> RemoveContactDetail(Guid id)
    {
        return await Execute(await _contactSvc.RemoveContactDetail(id));
    }
    [HttpGet("ContactDetail")]
    public async Task<ActionResult<ContactDetailResDto>> ContactDetailById(Guid id)
    {
        return await Execute(await _contactSvc.GetContactDetailById(id));
    }
}