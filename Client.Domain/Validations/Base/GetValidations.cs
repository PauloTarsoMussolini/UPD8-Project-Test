using Client.Domain.Validations.Base;
using FluentValidation.Results;

namespace Client.Domain.Validations.Base
{
    public static class GetValidations
    {
        public static Response GetErrors(this ValidationResult result)
        {
            var response = new Response();

            if (!result.IsValid)
            {
                foreach (var erro in result.Errors)
                {
                    response.Report.Add(new ReportErrors()
                    {
                        Code = erro.PropertyName,
                        Message = erro.ErrorMessage
                    });
                }

                return response;
            }

            return response;
        }
    }
}