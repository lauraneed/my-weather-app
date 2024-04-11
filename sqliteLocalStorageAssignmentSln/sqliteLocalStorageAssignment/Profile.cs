namespace sqliteLocalStorageAssignment
{
    public class Profile
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }

        public Profile()
        {
            Id = 0; // Set to 0 initially
            Name = "";
            Surname = "";
            Email = "";
            Bio = "";
        }

    }
}
