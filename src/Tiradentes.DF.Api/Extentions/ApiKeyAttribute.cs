using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace VipSgs.Api.Extentions
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        private const string ApyKeyName = "SecretKey";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApyKeyName, out var extractedHeader))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret Key não informada!"
                };
                return;
            }

            string jsonString = Decrypt(extractedHeader);

            var secretKey = JsonSerializer.Deserialize<SecretKey>(jsonString);

            if (secretKey == null)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret Key inválida!"
                };
                return;
            }

            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var apiKey = appSettings.GetValue<string>(ApyKeyName);

            if (apiKey.Equals(secretKey.secretKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret Key inválida!"
                };
                return;
            }

            await next();
        }

        public static string Decrypt(string encodedString)
        {
            string decodedString = null;

            try
            {
                byte[] data = Convert.FromBase64String(encodedString);
                decodedString = Encoding.UTF8.GetString(data);
            }
            catch (Exception)
            {
                decodedString = "{\"secretKey\":\"\",\"timestamp\":0}";
            }
            return decodedString;
        }
    }

    public class SecretKey
    {
        public string? secretKey { get; set; }
        public long? timestamp { get; set; } = 0;
    }
}