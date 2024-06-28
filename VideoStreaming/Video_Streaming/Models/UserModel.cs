namespace Video_Streaming.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public List<UserModel> users = new List<UserModel>();
    }
}
