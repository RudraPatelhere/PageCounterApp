namespace PageCounterApp.Services
{
    public interface IPageCounterService
    {
        int IncrementPageCount(string pageName); // This method is added to increment and return the visit count for a given page name.
    }
}
