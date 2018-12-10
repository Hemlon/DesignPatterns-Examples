namespace MediatorPattern
{
    public interface IMediator
    {
       void Recieve(BaseClass obj);
        void Register(BaseClass obj);
    }
}