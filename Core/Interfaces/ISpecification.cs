using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>>? Criteria { get; } // ability to add a where expression so that we can filter items from a list in our database.
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDescending { get; }
        bool IsDistinct { get; }
    }

    public interface ISpecification<T, TResult> : ISpecification<T>
    {
        Expression<Func<T, TResult>>? Select { get; }
    }
}