using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancer.Services.Translators
{
	public static class SubCategoryTranslator
	{
		#region ToEntity

		public static SubCategory ConverToSubCategoryEntity(SubCategoryContract subCategory)
		{
			SubCategory entitySubCategory = new SubCategory()
			{
				SubCategoryID = subCategory.SubCategoryID,
				Description = subCategory.Description,
				Image = subCategory.Image,
				MainCategoryID = subCategory.MainCategoryID,
				Name = subCategory.Name,
				Users = UsersTranslator.ConverToUserEntity(subCategory.Users)
				//MainCategory
				//Projects
			};
			return entitySubCategory;
		}

		public static List<SubCategory> ConverToSubCategoryEntity(List<SubCategoryContract> subCategories)
		{
			List<SubCategory> newSubCategories = new List<SubCategory>();
			foreach (var subCategory in subCategories)
			{
				newSubCategories.Add(ConverToSubCategoryEntity(subCategory));
			}
			return newSubCategories;
		}

		#endregion

		#region ToContract

		public static SubCategoryContract ConverToSubCategoryContract(SubCategory subCategory)
		{
			SubCategoryContract subCategoryContract = new SubCategoryContract()
			{
				SubCategoryID = subCategory.SubCategoryID,
				Description = subCategory.Description,
				Image = subCategory.Image,
				MainCategoryID = subCategory.MainCategoryID,
				Name = subCategory.Name,
				Users = UsersTranslator.ConverToUserContract(subCategory.Users.ToList())
				//MainCategory
				//Projects
			};
			return subCategoryContract;
		}

		public static List<SubCategoryContract> ConverToSubCategoryContract(List<SubCategory> subCategories)
		{
			List<SubCategoryContract> newSubCategories = new List<SubCategoryContract>();
			foreach (var subCategory in subCategories)
			{
				newSubCategories.Add(ConverToSubCategoryContract(subCategory));
			}
			return newSubCategories;
		}

		#endregion
	}
}