using LoveMyMoney.Domain.Abstract;

namespace LoveMyMoney.Domain.ValueObjects
{
    public class Category : ValueObject<Category>
    {
        internal Category() { }

        public Category(string name)
        {
            this.Name = name;
        }

        public Category SubCategory { get; set; }
        public string Name { get; set; }
    }
}