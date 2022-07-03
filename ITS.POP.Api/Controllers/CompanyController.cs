using ITS.POP.Domain.Model;
using ITS.POP.Infrastructure.Repositories.CompanyRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITS.POP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;


        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <returns></returns>

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            try
            {
                return await _companyRepository.GetCompaniesAsync();

            }
            catch (Exception e)
            {

                throw e;
            }
        }


    }
}
