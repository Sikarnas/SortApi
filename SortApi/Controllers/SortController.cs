using Microsoft.AspNetCore.Mvc;
using SortApi.Services;

namespace SortApi.Controllers
{
    [ApiController]
    public class SortController: ControllerBase 
    {
        private readonly BubbleSortService bubbleSort = new BubbleSortService();

        [HttpGet]
        [Route("/sort/array")]
        public ActionResult SortArray([FromQuery] string numbersToSort) 
        {
            return Ok(bubbleSort.GetSortedArray(numbersToSort));
        }

        [HttpGet]
        [Route("/sort/file")]
        public ActionResult SortFile([FromQuery] string fileName) 
        {
            return Ok(bubbleSort.GetSortedFile(fileName));
        }

    }
   
}