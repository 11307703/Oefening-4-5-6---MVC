using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Oefening4.ModelValidations
{
    public class CustomNoNumbers : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var list = new List<ModelValidationResult>();

            if (context.Model != null)
            {
                var objNoNumber = context.Model.ToString();
                if (objNoNumber.Any(char.IsDigit))
                {
                    var result = new ModelValidationResult("", "Text cannot contains any numbers!");
                    list.Add(result);
                }
            }

            return list;
        }
    }
}
