using FluentValidation;
using ITS.POP.Domain.Model;

namespace ITS.POP.Api.Application.Queries.Company.GetCompanies
{
    public class GetCompanyValidator:AbstractValidator<Companies>
    {
        public GetCompanyValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
            RuleFor(x => x.Address).NotNull().MaximumLength(50);
            RuleFor(x=>x.Status).NotEmpty().NotNull();
            RuleFor(x => x.CountOfWorker).NotNull();
            RuleFor(x=>x.Name).NotEmpty().NotNull().MaximumLength(15);
        }
    }
}
