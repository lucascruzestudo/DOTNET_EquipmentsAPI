using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using EquipamentosApi.Domain.Validators;

namespace EquipamentosApi.Domain.Models
{
    public class Equipment
    {
        private static int lastId = 0;

        [Key]
        public int Id { get; private set; }

        [Required(ErrorMessage = "Manufacturer is required to create an equipment!")]
        [MaxLength(50, ErrorMessage = "Manufacturer must have a maximum of 50 characters!")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Name is required to create an equipment!")]
        [MaxLength(50, ErrorMessage = "Name must have a maximum of 50 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Model is required to create an equipment!")]
        [MaxLength(50, ErrorMessage = "Model must have a maximum of 50 characters!")]
        [MinLength(3, ErrorMessage = "Model must have a minimum of 3 characters!")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Weight is required to create an equipment!")]
        [MaxWeight(100, ErrorMessage = "Weight must be less than 100 and a valid number!")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Serial number is required to create an equipment!")]
        [MaxLength(50, ErrorMessage = "Serial number must have a maximum of 50 characters!")]
        [MinLength(3, ErrorMessage = "Serial number must have a minimum of 3 characters!")]
        public string SerialNumber { get; set; }

        public Equipment(string manufacturer, string name, int weight, string serialNumber, string model)
        {
            Id = ++lastId;
            Manufacturer = manufacturer;
            Name = name;
            Weight = weight;
            SerialNumber = serialNumber;
            Model = model;
        }
    }
}
