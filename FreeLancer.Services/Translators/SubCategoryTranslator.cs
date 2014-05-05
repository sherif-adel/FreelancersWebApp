using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class SubCategoryTranslator
	{
		#region ToEntity

		public static SubCategory ConvertToSubCategoryEntity(SubCategoryContract subCategory)
		{
			SubCategory entitySubCategory = new SubCategory()
			{
				SubCategoryID = subCategory.SubCategoryID,
				Description = subCategory.Description,
				Image = subCategory.Image,
				MainCategoryID = subCategory.MainCategoryID,
				Name = subCategory.Name,
				Users = UsersTranslator.ConvertToUserEntity(subCategory.Users.ToList()),
                MainCategory=MainCategoryTranslator.ConvertToMainCategoryEntity(subCategory.MainCategory),
                Projects = ProjectTranslator.ConvertToProjectEntity(subCategory.Projects.ToList())
			};
			return entitySubCategory;
		}

		public static List<SubCategory> ConvertToSubCategoryEntity(List<SubCategoryContract> subCategories)
		{
			List<SubCategory> newSubCategories = new List<SubCategory>();
			foreach (var subCategory in subCategories)
			{
				newSubCategories.Add(ConvertToSubCategoryEntity(subCategory));
			}
			return newSubCategories;
		}

		#endregion

		#region ToContract

		public static SubCategoryContract ConvertToSubCategoryContract(SubCategory subCategory)
		{
			SubCategoryContract subCategoryContract = new SubCategoryContract()
			{
				SubCategoryID = subCategory.SubCategoryID,
				Description = subCategory.Description,
				Image = subCategory.Image,
				MainCategoryID = subCategory.MainCategoryID,
				Name = subCategory.Name,
				Users = UsersTranslator.ConvertToUserContract(subCategory.Users.ToList()),
                MainCategory = MainCategoryTranslator.ConvertToMainCategoryContract(subCategory.MainCategory),
                Projects = ProjectTranslator.ConvertToProjectContract(subCategory.Projects.ToList())
			};
			return subCategoryContract;
		}

		public static List<SubCategoryContract> ConvertToSubCategoryContract(List<SubCategory> subCategories)
		{
			List<SubCategoryContract> newSubCategories = new List<SubCategoryContract>();
			foreach (var subCategory in subCategories)
			{
				newSubCategories.Add(ConvertToSubCategoryContract(subCategory));
			}
			return newSubCategories;
		}

		#endregion
	}
}