namespace DentalApp.core.Contracts
{
    public interface IDashboardService
    {
        int GetTotalCount();
        int GetCountThisMonth();
        int GetCountThisWeek();
        int GetCountToday();
        Dictionary<string, int> GetMonthlyCount(int months);
    }
}