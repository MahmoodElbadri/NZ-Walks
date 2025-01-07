using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.IRepositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
