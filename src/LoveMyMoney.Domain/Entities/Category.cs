using LoveMyMoney.Domain.Abstract;
using System;
using System.Collections.Generic;

namespace LoveMyMoney.Domain.Entities
{
    public class Category : Entity
    {
        internal Category()
        {
            this.SubCategories = new List<Category>();
        }

        public Category ParentCategory { get; private set; }
        public string Name { get; private set; }
        public List<Category> SubCategories { get; private set; }

        public static Category Create(string name)
        {
            var category = new Category();
            category.Name = name;
            return category;
        }

        public void AddSubCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException("category", "It can't be null.");

            this.SubCategories.Add(category);
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}