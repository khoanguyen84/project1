using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface ICountryService
    {
        bool AddCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(int countryId);
        IList<Country> GetAllCountry();
        Country GetCountryById(int countryId);
        IList<Job> GetAllJob();
    }
}
