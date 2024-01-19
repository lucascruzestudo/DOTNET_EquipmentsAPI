using Microsoft.AspNetCore.Mvc;
using EquipamentosApi.Domain.Models;

namespace EquipamentosApi.Infrastructure.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private static List<Customer> customers = new List<Customer>();

    [HttpPost]
    public void CreateCustomer([FromBody] Customer customer)
    {
        customers.Add(customer);
    }

    [HttpGet]
    public IEnumerable<Customer> GetCustomers()
    {
        return customers;
    }
}