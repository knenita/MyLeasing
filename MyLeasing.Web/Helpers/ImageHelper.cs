using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MyLeasing.Web.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            string guid = Guid.NewGuid().ToString();
            string file = $"{guid}.jpg";
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot\\images\\Properties",
                file);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return $"~/images/Properties/{file}";
        }
    }
}