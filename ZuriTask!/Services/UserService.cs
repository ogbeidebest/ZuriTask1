namespace ZuriTask_.Services
{
    public class UserService : IUserService
    {
        public Data Get()
        {

            Data model = new Data()
            {
                SlackUsername = "Best Ogbeide",
                Backend = true,
                Age = 25,
                Bio = "HNG 9.0 Backend developer"

            };       
    
       
            return model;

        }
    }
}
