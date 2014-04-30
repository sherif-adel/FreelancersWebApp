using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
    public static class MainCategoryTranslator
    {
        #region MainCategory

        public static MainCategory ConverToMainCategoryEntity(MainCategoryContract maincategory)
        {
            MainCategory entityMainCategory = new MainCategory()
            {
                Image = maincategory.Image,
                MainCategoryID = maincategory.MainCategoryID,
                Name = maincategory.Name,
                SubCategories = SubCategoryTranslator.ConverToSubCategoryEntity(maincategory.SubCategories.ToList())
            };
            return entityMainCategory;
        }

        public static List<MainCategory> ConverToMainCategoryEntity(List<MainCategoryContract> maincategorys)
        {
            List<MainCategory> newMainCategorys = new List<MainCategory>();
            foreach (var maincategory in maincategorys)
            {
                newMainCategorys.Add(ConverToMainCategoryEntity(maincategory));
            }
            return newMainCategorys;
        }

        public static MainCategoryContract ConverToMainCategoryContract(MainCategory maincategory)
        {
            MainCategoryContract contractMainCategory = new MainCategoryContract()
            {
                Image = maincategory.Image,
                MainCategoryID = maincategory.MainCategoryID,
                Name = maincategory.Name,
                SubCategories = SubCategoryTranslator.ConverToSubCategoryContract(maincategory.SubCategories.ToList())
            };
            return contractMainCategory;
        }

        public static List<MainCategoryContract> ConverToMainCategoryContract(List<MainCategory> maincategorys)
        {
            List<MainCategoryContract> newMainCategorys = new List<MainCategoryContract>();
            foreach (var maincategory in maincategorys)
            {
                newMainCategorys.Add(ConverToMainCategoryContract(maincategory));
            }
            return newMainCategorys;
        }

        #endregion
    }
}
