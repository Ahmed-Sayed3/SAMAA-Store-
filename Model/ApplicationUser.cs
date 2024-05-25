namespace Supply_Chain_And_Transportation.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}