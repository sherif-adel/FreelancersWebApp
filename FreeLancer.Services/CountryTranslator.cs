//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class CountrysTranslator
    {
        #region Convert to Entities
    public static Country ConvertToCountryEntity(CountryContract country){
    
    if(country == null)
    	return null;
    Country entityCountry = new Country(){
    	
        CountryID=country.CountryID,
        Name=country.Name,
         };
    return entityCountry;}
    public static ICollection<Country> ConvertToCountryEntity(List<CountryContract> countrys)
    {
    		if(countrys == null)
    			return null;
    
           List<Country> newCountrys = new List<Country>();
    		foreach (var country in countrys)
    		{
    			newCountrys.Add(ConvertToCountryEntity(country));
    		}
    		return newCountrys;
    }

        #endregion

        #region Convert to Contracts
    public static CountryContract ConvertToCountryContract(Country country){
    
    		if(country == null)
    			return null;
    
    		CountryContract contractCountry = new CountryContract(){
    
            CountryID=country.CountryID,Name=country.Name,};
    return contractCountry;}
    public static List<CountryContract> ConvertToCountryContract(ICollection<Country> countrys){
    
    		if(countrys == null)
    			return null;
           List<CountryContract> newCountrys = new List<CountryContract>();
    			foreach (var country in countrys)
    			{
    				newCountrys.Add(ConvertToCountryContract(country));
    			}
    			return newCountrys;
    	}
        #endregion

    	
    
}}
