namespace ECommerce.API.Products.Profiles
{
    public class ProductProfile:AutoMapper.Profile
    {
        public ProductProfile() {
            CreateMap<Db.Product, Model.Product>();
        }
    }
}
