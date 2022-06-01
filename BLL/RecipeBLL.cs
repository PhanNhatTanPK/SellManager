using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeBLL
    {
        private static RecipeBLL instance;
        public static RecipeBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new RecipeBLL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllRecipe()
        {

            return RecipeDAL.Instance.GetAllRecipe();
        }    
        
        public RecipeDTO GetRecipeById(int id)
        {
            return RecipeDAL.Instance.GetRecipeById(id);
        }

        public bool AddRecipe(RecipeDTO recipe)
        {
            return RecipeDAL.Instance.AddRecipe(recipe);
        }

        public bool DeleteRecipe(int id)
        {
            return RecipeDAL.Instance.DeleteRecipe(id);
        }

        public bool DeleteRecipeByProductId(int id)
        {
            return RecipeDAL.Instance.DeleteRecipeByProductId(id);
        }

        public bool DeleteRecipeByUserId(int id)
        {
            return RecipeDAL.Instance.DeleteRecipeByUserId(id);
        }

        public DataTable GetRecipeByUserId(int id)
        {
            return RecipeDAL.Instance.GetRecipeByUserId(id);
        }
    }
}
