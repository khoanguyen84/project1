using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        /// <summary>
        /// get all country in DB
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("gets")]
        public IList<Country> Gets()
        {
            return _countryService.GetAllCountry();
        }

        /// <summary>
        /// get all country in DB
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetJobs")]
        public IList<Job> GetJob()
        {
            return _countryService.GetAllJob();
        }
    }
}