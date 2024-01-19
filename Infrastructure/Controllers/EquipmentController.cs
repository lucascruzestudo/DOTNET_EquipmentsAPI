using Microsoft.AspNetCore.Mvc;
using EquipamentosApi.Domain.Models;

namespace EquipamentosApi.Infrastructure.Controllers;

[ApiController]
[Route("[controller]")]
public class EquipmentController : ControllerBase
{
    private static List<Equipment> equipments = new List<Equipment>();

    [HttpPost]
    public void CreateEquipment([FromBody] Equipment equipment){
        equipments.Add(equipment);
    }

    [HttpGet]
    public IEnumerable<Equipment> GetEquipments(){
        return equipments;
    }
}