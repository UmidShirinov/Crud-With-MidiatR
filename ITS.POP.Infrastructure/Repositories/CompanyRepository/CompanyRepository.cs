using Dapper;
using ITS.POP.Domain.DbContext;
using ITS.POP.Domain.Dto;
using ITS.POP.Domain.Model;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.POP.Infrastructure.Repositories.CompanyRepository
{

    
   
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext dapperContext)
        {
            _context = dapperContext;
        }

        public Task<Company> AddCompanyAsync(Company Company)
        {
            throw new NotImplementedException();
        }

        public Task<NoDataDto> DeleteCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            var query =@"SELECT * FROM ""Company"" ";
          
            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                var companies = await connection.QueryAsync<Company>(query);
                connection.Close();
                return companies.ToList();
            }

        }

        public Task<Company> GetCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdateCompanyAsync(Company Company)
        {
            throw new NotImplementedException();
        }

     
    }
}
