using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RecipeDTO
    {
        private int recipeId, productId, userId, amounts;
        
        public RecipeDTO()
        {
            this.UserId = userId;
            this.ProductId = productId;
            this.Amounts = amounts;
        }
        public int RecipeId { get => recipeId; set => recipeId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Amounts { get => amounts; set => amounts = value; }
    }
}
