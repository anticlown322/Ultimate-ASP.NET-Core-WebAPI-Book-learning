using Domain.Entities.Models;

namespace Domain.Contracts;

public interface IDataShaper<T>
{
    IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString);
    ShapedEntity ShapeData(T shapedEntity, string fieldsString);
}