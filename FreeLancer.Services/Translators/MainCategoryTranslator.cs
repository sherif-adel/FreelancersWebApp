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

        public static MainCategory ConvertToMainCategoryEntity(MainCategoryContract maincategory)
        {
            MainCategory entityMainCategory = new MainCategory()
            {
                Image = maincategory.Image,
                MainCategoryID = maincategory.MainCategoryID,
                Name = maincategory.Name,
                SubCategories = SubCategoryTranslator.ConvertToSubCategoryEntity(maincategory.SubCategories.ToList())
            };
            return entityMainCategory;
        }

        public static List<MainCategory> ConvertToMainCategoryEntity(List<MainCategoryContract> maincategorys)
        {
            List<MainCategory> newMainCategorys = new List<MainCategory>();
            foreach (var maincategory in maincategorys)
            {
                newMainCategorys.Add(ConvertToMainCategoryEntity(maincategory));
            }
            return newMainCategorys;
        }

        public static MainCategoryContract ConvertToMainCategoryContract(MainCategory maincategory)
        {
            MainCategoryContract contractMainCategory = new MainCategoryContract()
            {
                Image = maincategory.Image,
                MainCategoryID = maincategory.MainCategoryID,
                Name = maincategory.Name,
                SubCategories = SubCategoryTranslator.ConvertToSubCategoryContract(maincategory.SubCategories.ToList())
            };
            return contractMainCategory;
        }

        public static List<MainCategoryContract> ConvertToMainCategoryContract(List<MainCategory> maincategorys)
        {
            List<MainCategoryContract> newMainCategorys = new List<MainCategoryContract>();
            foreach (var maincategory in maincategorys)
            {
                newMainCategorys.Add(ConvertToMainCategoryContract(maincategory));
            }
            return newMainCategorys;
        }

        #endregion
    }
}
