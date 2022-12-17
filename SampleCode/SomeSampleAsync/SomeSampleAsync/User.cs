namespace WebApi.Model
{
    public class User
    {
        public string Name { get; set; }
        public int FacebookFollowers { get; set; }
        public int InstagramFollowers { get; set; }
        public int TwitterFollowers { get; set; }

        public User(string name, int facebookFollowers, int instagramFollowers, int twitterFollowers)
        {
            Name = name;
            FacebookFollowers = facebookFollowers;
            InstagramFollowers = instagramFollowers;
            TwitterFollowers = twitterFollowers;
        }

        public override string ToString()
        {
            return $"Nom : {Name}, Facebook: {FacebookFollowers}, Insagram: {InstagramFollowers}, Twitter: {TwitterFollowers}";
        }
    }
}
