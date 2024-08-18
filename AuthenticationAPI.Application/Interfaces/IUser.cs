using AuthenticationAPI.Application.DTOs;
using Azure;
using ecommerceSharedLibrary.Response;

namespace AuthenticationAPI.Application.Interfaces
{
    public interface IUser
    {
        Task<ResponseModel> Register(AppUserDTO appUserDTO);
        Task<ResponseModel> Login(LoginDTO loginDTO);
        Task<GetUserDTO> GetUser(int userId);
    }
}
