using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RecipeDTO
    {
        private int recipeId, productId, userId;
      
        public int RecipeId { get => recipeId; set => recipeId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
