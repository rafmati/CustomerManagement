namespace CommonInterface
{
    public interface ICustomerView
    {
        int ID { get; }
        string PersonalNum { get; }
        string Name { get; }
        string LastName { get; }
        decimal TotalDebt { get; }
        string Note { get; }
    }
}