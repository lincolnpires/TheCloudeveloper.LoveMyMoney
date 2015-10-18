namespace LoveMyMoney.Domain.Abstract
{
    /// <summary> Represents an entity with your own identity.</summary>
    public class Entity
    {
        /// <summary> Default entity constructor.</summary>
        protected Entity() { }

        /// <summary> Identifier.</summary>
        public long Id { get; protected set; }
    }
}
