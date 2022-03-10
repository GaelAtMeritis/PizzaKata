namespace PizzaKata.Data;

public interface IDataSource<T>
{
    List<T> GetAll();
    T GetById(int id);
    
    T GetDefault();
}