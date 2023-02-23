using Application.Contracts.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
    public class RepositoryLocalFileStorage : IFileStorage
    {
        //private readonly IWebHostEnvironment env;
        private readonly string pathFile;

        public RepositoryLocalFileStorage(IConfiguration config)
        {
            this.pathFile = config["PathFile:PathFileCuentaBloqueada"];
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var extensionFile = Path.GetExtension(file.FileName);
            string fileName = $"{Guid.NewGuid()}{extensionFile}";
            if (!Directory.Exists(pathFile))
            {
                Directory.CreateDirectory(pathFile);
            }
            string finalPath = Path.Combine(pathFile, fileName);
            using (MemoryStream memoStream = new MemoryStream())
            {
                await memoStream.CopyToAsync(memoStream);
                var content = memoStream.ToArray();
                await File.WriteAllBytesAsync(finalPath, content);
            }
            return finalPath;
        }
    }
}
