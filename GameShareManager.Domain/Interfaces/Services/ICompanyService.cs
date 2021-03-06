﻿using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Services
{
    public interface ICompanyService : IService<Company,CompanyFilter>
    {
        
    }
}