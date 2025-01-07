using NZ_Walks.api.Data;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _dbContext;

        public ImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, ApplicationDbContext dbContext)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._httpContextAccessor = httpContextAccessor;
            this._dbContext = dbContext;
        }
        public async Task<Image> Upload(Image image)
        {
            // Build the local file path
            var localFilePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Images", $"{image.FileName}{image.FileExtension}");

            // Save the file to the server
            using (var stream = new FileStream(localFilePath, FileMode.Create))
            {
                await image.File.CopyToAsync(stream);
            }

            // Generate the file URL
            var urlFilePath = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/Images/{image.FileName}{image.FileExtension}";
            image.FilePath = urlFilePath;

            // Save the image record to the database
            await _dbContext.Images.AddAsync(image);
            await _dbContext.SaveChangesAsync();

            return image;
        }

    }
}
