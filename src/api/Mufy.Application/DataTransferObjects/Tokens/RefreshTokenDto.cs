using System;

namespace Mufy.Application.DataTransferObjects.Tokens
{
    class RefreshTokenDto
    {
        public string Token { get; set; }
        public string JwtId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Used { get; set; }
        public int UserId { get; set; }
        public bool Active() => DateTime.UtcNow <= ExpiryDate;
    }
}
