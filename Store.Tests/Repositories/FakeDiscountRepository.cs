using System;
using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories;

public class FakeDiscountRepository : IDiscountRepository
{
    public Discount? get(int? code)
    {
        if (code == 12345678)
            return new Discount(10, DateTime.Now.AddDays(5));
        if (code == 11111111)
            return new Discount(10, DateTime.Now.AddDays(-5));
        return null;
    }

    public Discount Get(int? code)
    {
        throw new NotImplementedException();
    }

    public object Get(string? promoCode)
    {
        throw new NotImplementedException();
    }
}