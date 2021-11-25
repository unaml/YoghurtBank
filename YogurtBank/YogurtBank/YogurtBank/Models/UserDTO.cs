using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YogurtBank.Models
{
    public record UserDTO(int Id, string Username);

    public record UserDetailsDTO(int Id, string Username, int Age, Gender Gender, ICollection<CollaborationRequest> Collaborations) : UserDTO(Id, Username);

    public record UserCreateDTO 
    {
          
        public string Username { get; init; }
        public int Age { get; init; }
        public Gender Gender { get; init; }
        public ICollection<CollaborationRequest> Collaborations { get; init; }
    
    }

    public record UserUpdateDTO : UserCreateDTO 
    {
        public int Id { get; init; }
    }
}