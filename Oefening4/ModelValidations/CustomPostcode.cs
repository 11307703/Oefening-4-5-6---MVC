using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Oefening4.ModelValidations
{
    public class CustomPostcode : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var list = new List<ModelValidationResult>();

            if (context.Model != null)
            {
                var objPostCode = context.Model.ToString();
                if (objPostCode == "3500" || objPostCode == "3600" || objPostCode == "3990")
                {
                    var result = new ModelValidationResult("", "Postcode cannot be 3500, 3600 or 3990");
                    list.Add(result);
                }
            }

            return list;
        }
    }
}
