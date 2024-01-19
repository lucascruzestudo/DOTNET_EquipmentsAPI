
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using EquipamentosApi.Domain.Enums;

namespace EquipamentosApi.Domain.Models;
public class Customer{

    private static int lastId = 0;

    [Key]
    public int Id { get; private set; }

    [Required(ErrorMessage = "Name is required to create a customer!")]
    [MaxLength(50, ErrorMessage = "Name must have a maximum of 50 characters!")]

    public string Name { get; set; }

    [Required(ErrorMessage = "Customer type is required to create a customer!")]
    [Range(1, 2, ErrorMessage = "Customer type must be 1 for Physical Person or 2 for Legal Person!")]
    public int CustomerType { get; set; }

    public string? Cpf { get; set; }
    
    public string? Cnpj { get; set; }

    public string? Rg { get; set; }

    [Required(ErrorMessage = "Address is required to create a customer!")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Address number is required to create a customer!")]
    public string AddressNumber { get; set; }

    [Required(ErrorMessage = "Neighborhood is required to create a customer!")]
    public string Neighborhood { get; set; }

    [Required(ErrorMessage = "City is required to create a customer!")]
    public string City { get; set; }

    [Required(ErrorMessage = "State is required to create a customer!")]
    public string State { get; set; }

    [Required(ErrorMessage = "Cep is required to create a customer!")]
    public string Cep { get; set; }

    [Required(ErrorMessage = "Phone is required to create a customer!")]
    public string Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    [EmailAddress(ErrorMessage = "Email must be a valid email!")]
    public string Email { get; set; }

    public string? StateRegistration { get; set; }

    public string? MunicipalRegistration { get; set; }

    public string Contact { get; set; }

    [Required(ErrorMessage = "Social reason is required to create a customer!")]
    public string SocialReason { get; set; }

    //constructor with optional parameters
    public Customer(string name, int customerType, string address, string addressNumber, string neighborhood, string city, string state, string cep, string phone, string email, string socialReason, string contact, string? cpf = null, string? cnpj = null, string? rg = null, string? phone2 = null, string? phone3 = null, string? stateRegistration = null, string? municipalRegistration = null)
    {
        Id = ++lastId;
        Name = name;
        CustomerType = customerType;
        Cpf = cpf;
        Cnpj = cnpj;
        Rg = rg;
        Address = address;
        AddressNumber = addressNumber;
        Neighborhood = neighborhood;
        City = city;
        State = state;
        Cep = cep;
        Phone = phone;
        Phone2 = phone2;
        Phone3 = phone3;
        Email = email;
        StateRegistration = stateRegistration;
        MunicipalRegistration = municipalRegistration;
        Contact = contact;
        SocialReason = socialReason;
    }
    

}