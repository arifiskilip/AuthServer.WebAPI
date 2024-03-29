﻿using AuthServer.Core.Dtos;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using AuthServer.Service.Mappings;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.ResponseDto;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new AppUser { Email = createUserDto.Email, UserName = createUserDto.UserName };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                return Response<AppUserDto>.Fail(400, new ErrorDto(errors, true));
            }
            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }

        public async Task<Response<AppUserDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return Response<AppUserDto>.Fail("UserName not found", 404, true);
            }
    
            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }
    }
}
