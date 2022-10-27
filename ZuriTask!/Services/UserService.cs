namespace ZuriTask_.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<Model> Get()
        {
            List<Model> list = new List<Model>();
            Model model = new Model()
            {
                SlackUsername = "Ogbeidebest",
                Backend = true,
                Age = 25,
                Bio = "I am highly motivated towards innovative programming as this is what I am passionate about, I pride myself on my reputation to not just solve problems, but to do so in short time spans with clean and optimized codebases that ensure easy maintainability of the project. By wrapping my problem-solving skills around creativity and ever-increasing technical know-how, I build world-class software that will scale in any industry."
            };
            list.Add(model);
            return list;

        }
    }
}
