﻿using API.Models;

namespace API;

public interface IPortfolioRepository
{
    Task<List<Stock>> GetUserPortfolio(AppUser user);
    Task<Portfolio> CreateAsync(Portfolio portfolio);
  

}
