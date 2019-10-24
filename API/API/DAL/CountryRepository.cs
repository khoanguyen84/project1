using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class CountryRepository : BaseRepository, ICountryRepository
    {
        public bool AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public IList<Country> GetAllCountry()
        {
            IList<Country> customerList = SqlMapper.Query<Country>(con, "GetAllCountries", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public IList<Job> GetAllJob()
        {
            IList<Job> jobs = SqlMapper.Query<Job>(con, "GetAllJob", commandType: CommandType.StoredProcedure).ToList();
            return jobs;
        }

        public Country GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
