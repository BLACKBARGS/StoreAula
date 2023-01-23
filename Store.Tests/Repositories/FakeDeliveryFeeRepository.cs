using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories;

public class FakeDeliveryFeeRepository
{
    public decimal Get(string zipCode)
    {
        return 10;
    }
}