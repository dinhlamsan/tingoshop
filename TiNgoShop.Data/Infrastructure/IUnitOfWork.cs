namespace TiNgoShop.Data.Infrastructure
{
    //Thiết kế phương thức Commit()
    public interface IUnitOfWork
    {
        void Commit();
    }
}