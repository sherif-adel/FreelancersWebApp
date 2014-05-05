//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class MainCategorysTranslator
    {
        #region Convert to Entities
    public static MainCategory ConvertToMainCategoryEntity(MainCategoryContract maincategory){
    
    if(maincategory == null)
    	return null;
    MainCategory entityMainCategory = new MainCategory(){
    	
        MainCategoryID=maincategory.MainCategoryID,
        Name=maincategory.Name,
        Image=maincategory.Image,
        
            SubCategories=SubCategorysTranslator.ConvertToSubCategoryEntity(maincategory.SubCategories),
         };
    return entityMainCategory;}
    public static ICollection<MainCategory> ConvertToMainCategoryEntity(List<MainCategoryContract> maincategorys)
    {
    		if(maincategorys == null)
    			return null;
    
           List<MainCategory> newMainCategorys = new List<MainCategory>();
    		foreach (var maincategory in maincategorys)
    		{
    			newMainCategorys.Add(ConvertToMainCategoryEntity(maincategory));
    		}
    		return newMainCategorys;
    }

        #endregion

        #region Convert to Contracts
    public static MainCategoryContract ConvertToMainCategoryContract(MainCategory maincategory){
    
    		if(maincategory == null)
    			return null;
    
    		MainCategoryContract contractMainCategory = new MainCategoryContract(){
    
            MainCategoryID=maincategory.MainCategoryID,Name=maincategory.Name,Image=maincategory.Image,             SubCategories=SubCategorysTranslator.ConvertToSubCategoryContract(maincategory.SubCategories),};
    return contractMainCategory;}
    public static List<MainCategoryContract> ConvertToMainCategoryContract(ICollection<MainCategory> maincategorys){
    
    		if(maincategorys == null)
    			return null;
           List<MainCategoryContract> newMainCategorys = new List<MainCategoryContract>();
    			foreach (var maincategory in maincategorys)
    			{
    				newMainCategorys.Add(ConvertToMainCategoryContract(maincategory));
    			}
    			return newMainCategorys;
    	}
        #endregion

    	
    
}}
