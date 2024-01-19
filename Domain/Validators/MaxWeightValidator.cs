using System.ComponentModel.DataAnnotations;

namespace EquipamentosApi.Domain.Validators;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class MaxWeightAttribute : ValidationAttribute
{
    private readonly int _maxWeight;

    public MaxWeightAttribute(int maxWeight)
    {
        _maxWeight = maxWeight;
    }

    public override bool IsValid(object? value)
    {
        if (value != null)
        {
            if (int.TryParse(value.ToString(), out int weight))
            {
                return weight <= _maxWeight;
            }
            else
            {
                return false;
            }
        }

        return false;
    }
}
