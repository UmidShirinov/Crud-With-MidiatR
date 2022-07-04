using ITS.POP.Api.Application.Queries.Company.GetCompanies;
using ITS.POP.Domain.Model;
using ITS.POP.Infrastructure.Repositories.CompanyRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITS.POP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMediator _mediator;


        public CompanyController(ICompanyRepository companyRepository , IMediator mediator)
        {
            _companyRepository = companyRepository;
            _mediator = mediator;
        }
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <returns></returns>

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IActionResult> GetCompaniesAsync()
        {
            try
            {
                var query = new GetCompanyQuery();
                var result = await _mediator.Send(query);
                return Ok(result);

            }
            catch (Exception e)
            {

                throw e;
            }
        }


    }
}
