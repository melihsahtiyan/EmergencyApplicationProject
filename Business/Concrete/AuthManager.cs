using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
            private IUserService _userService;
            private ITokenHelper _tokenHelper;

            public AuthManager(IUserService userService, ITokenHelper tokenHelper)
            {
                _userService = userService;
                _tokenHelper = tokenHelper;
            }

            public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
                var user = new User
                {
                    Email = userForRegisterDto.Email,
                    FirstName = userForRegisterDto.FirstName,
                    LastName = userForRegisterDto.LastName,
                    IdentityNumber = userForRegisterDto.IdentityNumber,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true
                };
                _userService.Add(user);
                return new SuccessDataResult<User>(user, Messages.UserRegistered);
            }

            public IDataResult<User> Login(UserForLoginDto userForLoginDto)
            {
                var userToCheck = _userService.GetByMail(userForLoginDto.Email).Data;
                if (userToCheck == null)
                {
                    return new ErrorDataResult<User>(Messages.UserNotFound);
                }

                if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash,
                        userToCheck.PasswordSalt))
                {
                    return new ErrorDataResult<User>(Messages.PasswordError);
                }

                return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
            }

            public IDataResult<User> Update(UserForUpdateDto userForUpdateDto, string password)
            {
                var user = _userService.GetByMail(userForUpdateDto.Email);
                var userToCheck = user.Data;
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                if (userToCheck == null)
                {
                    return new ErrorDataResult<User>(Messages.UserNotFound);
                }

                if (!HashingHelper.VerifyPasswordHash(userForUpdateDto.PasswordToCheck, userToCheck.PasswordHash,
                        userToCheck.PasswordSalt))
                {
                    return new ErrorDataResult<User>(Messages.PasswordError);
                }

                if (userForUpdateDto.PasswordToCheck == userForUpdateDto.Password)
                {
                    return new ErrorDataResult<User>(Messages.SamePassword);
                }


                user.Data.Email = userForUpdateDto.Email;
                user.Data.FirstName = userForUpdateDto.FirstName;
                user.Data.LastName = userForUpdateDto.LastName;
                user.Data.PasswordHash = passwordHash;
                user.Data.PasswordSalt = passwordSalt;
                user.Data.Status = true;

                _userService.Update(user.Data);
                return new SuccessDataResult<User>(user.Data, Messages.UserUpdated);
            }

            public IResult UserExists(string email)
            {
                if (_userService.GetByMail(email).Data != null)
                {
                    return new ErrorResult(Messages.UserAlreadyExists);
                }

                return new SuccessResult(Messages.UserNotFound);
            }

            public IDataResult<AccessToken> CreateAccessToken(User user)
            {
                var claims = _userService.GetClaims(user).Data;
                var accessToken = _tokenHelper.CreateToken(user, claims);
                return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
            }
    }
}

