
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

SubCategory entitySubCategory = new SubCategory(){

    SubCategoryID=subcategory.SubCategoryID,
    Name=subcategory.Name,
    Description=subcategory.Description,
    Image=subcategory.Image,
    MainCategoryID=subcategory.MainCategoryID,
    


        MainCategory=MainCategorysTranslator.ConvertToMainCategoryEntity(subcategory.MainCategory),
    Projects=ProjectsTranslator.ConvertToProjectEntity(subcategory.Projects),
    Users=UsersTranslator.ConvertToUserEntity(subcategory.Users),
    
 };
return entitySubCategory;}

public static ICollection<SubCategory> ConvertToSubCategoryEntity(ICollection<SubCategoryContract> subcategorys){

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

SubCategoryContract contractSubCategory = new SubCategoryContract(){

            SubCategoryID=subcategory.SubCategoryID,Name=subcategory.Name,Description=subcategory.Description,Image=subcategory.Image,MainCategoryID=subcategory.MainCategoryID,
                MainCategory=MainCategorysTranslator.ConvertToMainCategoryContract(subcategory.MainCategory),
                Projects=ProjectsTranslator.ConvertToProjectContract(subcategory.Projects),
                Users=UsersTranslator.ConvertToUserContract(subcategory.Users),};
return contractSubCategory;}

public static ICollection<SubCategoryContract> ConvertToSubCategoryContract(ICollection<SubCategory> subcategorys){

       List<SubCategoryContract> newSubCategorys = new List<SubCategoryContract>();
    			foreach (var subcategory in subcategorys)
    			{
    				newSubCategorys.Add(ConvertToSubCategoryContract(subcategory));
    			}
    			return newSubCategorys;
    	}
        #endregion

    	


}}
