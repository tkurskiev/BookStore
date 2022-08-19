using BookStore.API.Models;
using System.Linq.Expressions;

namespace BookStore.API.Data.Repositories
{
    /// <summary>
    /// Описывает репозиторий для работы с сущностями типа <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface IRepository<T> where T : EntityBase
    {
        /// <summary>
        /// Получить сущность по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T?> GetAsync(int id);

        /// <summary>
        /// Получить все сущности типа <see cref="T"/>
        /// </summary>
        /// <returns></returns>
        Task<List<T>?> GetAllAsync();

        /// <summary>
        /// Получить все сущности типа <see cref="T"/>, удовлетворяющие условию <param name="predicate"></param>
        /// </summary>
        /// <param name="predicate">Условие, исходя из которого ищутся подходящие сущности</param>
        /// <returns></returns>
        Task<List<T>?> GetAllAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Добавить сущность <param name="entity"></param> в базу
        /// </summary>
        /// <param name="entity">Сущность типа <see cref="T"/></param>
        /// <returns></returns>
        Task AddAsync(T entity);

        /// <summary>
        /// Удалить сущность с заданным Id
        /// </summary>
        /// <param name="id">Id сущности для удаления</param>
        /// <returns></returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// Удалить сущность <param name="entity"></param> из базы
        /// </summary>
        /// <param name="entity">Сущность типа <see cref="T"/></param>
        /// <returns></returns>
        Task DeleteAsync(T entity);

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="entity">Сущность типа <see cref="T"/></param>
        /// <returns></returns>
        Task UpdateAsync(T entity);
    }
}
