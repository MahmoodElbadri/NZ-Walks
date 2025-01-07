using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO.ImageDTOs;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this._imageRepository = imageRepository;
        }

        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageAddRequest imageAddRequest)
        {
            ValidateFileUpload(imageAddRequest);
            if (ModelState.IsValid)
            {
                var image = new Image
                {
                    File = imageAddRequest.File,
                    FileExtension = Path.GetExtension(imageAddRequest.File.FileName),
                    FileDescription = imageAddRequest.FileDescription,
                    FileName = imageAddRequest.FileName,
                    FileSizeInBytes = imageAddRequest.File.Length
                };
                await _imageRepository.Upload(image);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageAddRequest imageAddRequest)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(imageAddRequest.File.FileName)))
            {
                ModelState.AddModelError("File", "Invalid file type");
            }
            if (!(imageAddRequest.File.Length < (10 * 1024 * 1024)))
            {
                ModelState.AddModelError("File", "File size is too large you can't upload file size more than 10MB");
            }
        }
    }
}
