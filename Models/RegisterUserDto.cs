﻿namespace bemusic.Models
{
    public class RegisterUserDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
        public int SupplierId { get; set; }
        public int RoleId { get; set; } = 1;
    }
}
