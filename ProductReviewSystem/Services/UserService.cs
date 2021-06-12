using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewSystem.Models;
using ProductReviewSystem.Models.ViewModels;
using ProductReviewSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ProductReviewSystem.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User AddUser(CreateUserViewModel model)
        {
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Gender = model.Gender,
                CreatedAt = DateTime.Now
            };

            return _userRepository.AddUser(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public User FindById(int id)
        {
            return _userRepository.FindById(id);
        }

        public IEnumerable<SelectListItem> GetUserList()
        {
            return _userRepository.GetUsers().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString(),
            }).ToList();

        }
        
        public List<UserViewModel> GetUsers()
        {
            var users = _userRepository.GetUsers().Select(u => new UserViewModel
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Gender = u.Gender,
            }).ToList();

            return users;
        }
         public User LoginUser(string email, string password)
        {
            User user = _userRepository.FindUserByEmail(email);

            if (user == null) {
                Console.WriteLine("User not found");
                return null;
             }

            string hashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(hashedPassword))
            {
                Console.WriteLine("User is found");
                return user;
            }

            return null;
        }
          private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

            return hashed;
        }
        public void RegisterUser(string email, string name, string password, string userType)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(password, saltString);

            User user = new User
            {
                Email = email,
                HashSalt = saltString,
                PasswordHash = hashedPassword,
                // Role = _userRepository.FindRole(userType.ToLower())
            };

            _userRepository.AddUser(user);
        }

        
    }
}