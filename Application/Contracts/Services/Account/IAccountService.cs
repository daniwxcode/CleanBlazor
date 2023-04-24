using System.Threading.Tasks;
using Otr.Dccfe.Application.Interfaces.Common;
using Otr.Dccfe.Application.Requests.Identity;
using Otr.Dccfe.Shared.Wrapper;

namespace Otr.Dccfe.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}