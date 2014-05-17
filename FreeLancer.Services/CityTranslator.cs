//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class CitysTranslator
    {
        #region Convert to Entities
    public static City ConvertToCityEntity(CityContract city){
    
    if(city == null)
    	return null;
    City entityCity = new City(){
    	
        CityID=city.CityID,
        Name=city.Name,
        CountryID=city.CountryID,
         };
    return entityCity;}
    public static ICollection<City> ConvertToCityEntity(List<CityContract> citys)
    {
    		if(citys == null)
    			return null;
    
           List<City> newCitys = new List<City>();
    		foreach (var city in citys)
    		{
    			newCitys.Add(ConvertToCityEntity(city));
    		}
    		return newCitys;
    }

        #endregion

        #region Convert to Contracts
    public static CityContract ConvertToCityContract(City city){
    
    		if(city == null)
    			return null;
    
    		CityContract contractCity = new CityContract(){
    
            CityID=city.CityID,Name=city.Name,CountryID=city.CountryID,};
    return contractCity;}
    public static List<CityContract> ConvertToCityContract(ICollection<City> citys){
    
    		if(citys == null)
    			return null;
           List<CityContract> newCitys = new List<CityContract>();
    			foreach (var city in citys)
    			{
    				newCitys.Add(ConvertToCityContract(city));
    			}
    			return newCitys;
    	}
        #endregion

    	
    
}}
