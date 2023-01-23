using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces;

public interface IDiscountRepository
{
    Discount Get(int? code);
    object Get(string? promoCode);
}