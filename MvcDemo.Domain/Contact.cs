using System;


namespace MvcDemo.Domain
{
    [PetaPoco.TableName("Contacts")]
    [PetaPoco.PrimaryKey("Id")]
    public class Contact  : Entity
    {
        public DateTime Created { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}