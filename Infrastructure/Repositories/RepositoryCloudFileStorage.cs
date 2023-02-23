using Application.Contracts.Infrastructure;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
    public class RepositoryCloudFileStorage : IFileStorage
    {
        private readonly IConfiguration _config;

        public RepositoryCloudFileStorage(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            string urlFile = string.Empty;
            using (MemoryStream memoStream = new MemoryStream())
            {
                file.CopyTo(memoStream);
                var fileBytes = memoStream.ToArray();
                string fileName = Guid.NewGuid().ToString();
                Cloudinary cloudinary= new Cloudinary(new Account(_config["Cloudinary:CloudName"],
                                                                _config["Cloudinary:APIKey"], 
                                                                _config["Cloudinary:APISecret"]));
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(fileName, new MemoryStream(fileBytes))
                };
                var uploadResult = await cloudinary.UploadAsync(uploadParams);
                urlFile = uploadResult.SecureUrl.ToString();
            }
            return urlFile;
        }
    }
}
