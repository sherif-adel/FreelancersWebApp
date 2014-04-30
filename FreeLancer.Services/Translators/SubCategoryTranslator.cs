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

		public static SubCategory ConverToSubCategoryEntity(SubCategoryContract subCategory)
		{
			SubCategory entitySubCategory = new SubCategory()
			{
				SubCategoryID = subCategory.SubCategoryID,
				Description = subCategory.Description,
				Image = subCategory.Image,
				MainCategoryID = subCategory.MainCategoryID,
				Name = subCategory.Name,
				Users = UsersTranslator.ConverToUserEntity(subCategory.Users.ToList()),
                MainCategory=MainCategoryTranslator.ConverToMainCategoryEntity(subCategory.MainCategory),
                Projects = ProjectTranslator.ConverToProjectEntity(subCategory.Projects.ToList())
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
				Users = UsersTranslator.ConverToUserContract(subCategory.Users.ToList()),
                MainCategory = MainCategoryTranslator.ConverToMainCategoryContract(subCategory.MainCategory),
                Projects = ProjectTranslator.ConverToProjectContract(subCategory.Projects.ToList())
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