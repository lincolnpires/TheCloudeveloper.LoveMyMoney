namespace LoveMyMoney.Domain.Abstract
{
    /// <summary>
    /// Represents an object with a descriptive aspect and no identity.
    /// </summary>
    /// <typeparam name="VO"></typeparam>
    public abstract class ValueObject<VO> where VO : ValueObject<VO> { }
}
