using Contacts.Application.Dto.Request;
using Contacts.Application.Dto.Response;
using Contacts.Application.Wrapper;

namespace Contacts.Application.Service.Contact.Interface;

public interface IContactSvc
{
    Task<SingleDataResponse<bool>> CreateContact(ContactReqDto dto);
    Task<SingleDataResponse<bool>> DeleteContact(Guid id);
    Task<ListDataResponse<ContactResDto>> GetAllContacts();
    Task<SingleDataResponse<ContactResDto>> GetContactById(Guid id);
    Task<SingleDataResponse<bool>> AddContactDetail(ContactDetailReqDto dto);
    Task<SingleDataResponse<bool>> RemoveContactDetail(Guid id);
    Task<SingleDataResponse<ContactDetailResDto>> GetContactDetailById(Guid id);
}