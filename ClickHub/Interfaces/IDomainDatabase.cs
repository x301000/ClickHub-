﻿using ClickHub.Models;

namespace ClickHub.Interfaces
{
    public interface IDomainDatabase
    {
        Task<List<ClickData>> GetClicksInRangeAsync(DateTime startDate, DateTime endDate);
        Task<Dictionary<int, DomainConfig>> LoadDomainsAsync();
        Task<bool> AddDomainAsync(string landingPageUrl);
        Task<bool> RemoveDomainAsync(int id);
        Task<bool> UpdateDomainAsync(int id, string landingPageUrl);
        Task ProcessClickDataAsync(ClickData clickData);
    }
}