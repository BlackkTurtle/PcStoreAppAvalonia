﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PcStore.DAL.Specification
{
    public interface IBaseSpecification<T, TResult>
    {
        Expression<Func<T, bool>> Predicate { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        Expression<Func<T, object>> GroupBy { get; }
        int? Take { get; }
        int? Skip { get; }
        bool IsPagingEnabled { get; }
        string CacheKey { get; }
        int CacheMinutes { get; }
        Expression<Func<T, TResult>> Selector { get; }
    }
}
