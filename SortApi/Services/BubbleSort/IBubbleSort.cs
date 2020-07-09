using SortApi.Models;

namespace SortApi.Services
{
    public interface IBubbleSortService
    {
        SortResponse GetSortedArray(string numbersToSort);
        SortResponse GetSortedFile(string fileName);
    }
}