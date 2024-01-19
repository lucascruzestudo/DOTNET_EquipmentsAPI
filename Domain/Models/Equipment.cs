using System.ComponentModel.DataAnnotations;
using EquipamentosApi.Domain.Validators;

namespace EquipamentosApi.Models;

public class Equipment
{
    [Required(ErrorMessage = "Manufacturer is required to create an equipment!")]
    [MaxLength(50, ErrorMessage = "Manufacturer must have a maximum of 50 characters!")]
    public string Manufacturer { get; set; }

    [Required(ErrorMessage = "Name is required to create an equipment!")]
    [MaxLength(50, ErrorMessage = "Name must have a maximum of 50 characters!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Brand is required to create an equipment!")]
    [MaxLength(50, ErrorMessage = "Brand must have a maximum of 50 characters!")]
    public string Brand { get; set; }

    [Required(ErrorMessage = "Weight is required to create an equipment!")]
    [MaxWeight(100, ErrorMessage = "Weight must be less than 100 and a valid number!")]
    public string Weight { get; set; }

    public Equipment(string manufacturer, string name, string brand, string weight)
    {
        Manufacturer = manufacturer;
        Name = name;
        Brand = brand;
        Weight = weight;

    }

}