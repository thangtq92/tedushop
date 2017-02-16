using TeduShop.Data.Infrastructure;
using TeduShop.Model;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISliderRepository : IRepository<Slider> { }

    public class SliderRepository : RepositoryBase<Slider>, ISliderRepository
    {
        public SliderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}