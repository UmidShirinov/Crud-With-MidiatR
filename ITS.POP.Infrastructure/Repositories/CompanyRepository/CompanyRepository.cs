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

        public Task<Companies> AddCompanyAsync(Companies Company)
        {
            throw new NotImplementedException();
        }

        public Task<NoDataDto> DeleteCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Companies>> GetCompaniesAsync()
        {
            var query =@"SELECT * FROM ""Company"" ";
          
            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                var companies = await connection.QueryAsync<Companies>(query);
                connection.Close();
                return companies.ToList();
            }

        }

        public Task<Companies> GetCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Companies> GetCompanyByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Companies> UpdateCompanyAsync(Companies Company)
        {
            throw new NotImplementedException();
        }

     
    }
}
