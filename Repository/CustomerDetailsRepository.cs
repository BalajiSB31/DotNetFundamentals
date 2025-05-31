using ICustomerDetailsInterface;
namespace CustomerDetailsRepository
{

    public class CustomerImplementation : ICustomerDetails
    {
        // Implement the IService interface here
        public string fetchcustomerdetails(int customerID)
        {
            return "Balaji";
        }
    }
}