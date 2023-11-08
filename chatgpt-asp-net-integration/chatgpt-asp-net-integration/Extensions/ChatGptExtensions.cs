using OpenAI_API;

namespace ChatGPT.ASP.NET.Integration.Extensions
{
    public static class ChatGptExtensions
    {

        public static WebApplicationBuilder AddChatGpt(
            this WebApplicationBuilder builder
            /*, IConfiguration configuration*/)
        {
            // var key = configuration["ChatGpt:Key"];
            var key = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            var chat = new OpenAIAPI(key);
            builder.Services.AddSingleton(chat);
            return builder;
        }
    }
}
