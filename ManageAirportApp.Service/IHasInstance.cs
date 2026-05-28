namespace ManageAirportApp.Service
{
    public interface IHasInstance<TService>
    {
        TService GetInstance();
    }
}