using Microsoft.AspNetCore.Mvc;
using ICustomerDetailsInterface;
using CustomerDetailsRepository;


[ApiController]
[Route("api/[controller]")]
public class CustomerDetails : ControllerBase
{
    private readonly ICustomerDetails _ICustomerDetails;

    public CustomerDetails(ICustomerDetails _ICustomerDetails)
    {
        _ICustomerDetails = _ICustomerDetails;
    }

    public string FetchCustomerDetails(int CustomerID)
    {
        _ICustomerDetails.fetchcustomerdetails(CustomerID);
        return "Balaji";
    }

}