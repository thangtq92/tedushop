using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISliderRepository { }

    public class SliderRepository : RepositoryBase<Product>, ISliderRepository
    {
        public SliderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}