//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class SubCategorysTranslator
    {
        #region Convert to Entities
    public static SubCategory ConvertToSubCategoryEntity(SubCategoryContract subcategory){
    
    if(subcategory == null)
    	return null;
    SubCategory entitySubCategory = new SubCategory(){
    	
        SubCategoryID=subcategory.SubCategoryID,
        Name=subcategory.Name,
        Description=subcategory.Description,
        Image=subcategory.Image,
        MainCategoryID=subcategory.MainCategoryID,
         };
    return entitySubCategory;}
    public static ICollection<SubCategory> ConvertToSubCategoryEntity(List<SubCategoryContract> subcategorys)
    {
    		if(subcategorys == null)
    			return null;
    
           List<SubCategory> newSubCategorys = new List<SubCategory>();
    		foreach (var subcategory in subcategorys)
    		{
    			newSubCategorys.Add(ConvertToSubCategoryEntity(subcategory));
    		}
    		return newSubCategorys;
    }

        #endregion

        #region Convert to Contracts
    public static SubCategoryContract ConvertToSubCategoryContract(SubCategory subcategory){
    
    		if(subcategory == null)
    			return null;
    
    		SubCategoryContract contractSubCategory = new SubCategoryContract(){
    
            SubCategoryID=subcategory.SubCategoryID,Name=subcategory.Name,Description=subcategory.Description,Image=subcategory.Image,MainCategoryID=subcategory.MainCategoryID,};
    return contractSubCategory;}
    public static List<SubCategoryContract> ConvertToSubCategoryContract(ICollection<SubCategory> subcategorys){
    
    		if(subcategorys == null)
    			return null;
           List<SubCategoryContract> newSubCategorys = new List<SubCategoryContract>();
    			foreach (var subcategory in subcategorys)
    			{
    				newSubCategorys.Add(ConvertToSubCategoryContract(subcategory));
    			}
    			return newSubCategorys;
    	}
        #endregion

    	
    
}}
