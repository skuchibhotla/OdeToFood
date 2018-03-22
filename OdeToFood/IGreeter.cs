using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            //throw new System.NotImplementedException();
            //return "Greetings!";
            return _configuration["Greeting"];
        }
    }
}