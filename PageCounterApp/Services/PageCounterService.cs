using System.Collections.Generic;

namespace PageCounterApp.Services
{
    public class PageCounterService : IPageCounterService
    {
        private readonly Dictionary<string, int> _pageCounts = new(); // This is added to store visit counts for each page in memory.

        public int IncrementPageCount(string pageName)
        {
            if (!_pageCounts.ContainsKey(pageName)) // This will check if the page name exists in the dictionary.
            {
                _pageCounts[pageName] = 0; // This will initialize the count to 0 if the page is not already in the dictionary.
            }
            return ++_pageCounts[pageName]; // This will increment the count for the given page and return the updated value.
        }
    }
}
