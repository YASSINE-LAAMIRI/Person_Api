namespace PersonApi.Model
{
    public class Person
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}
