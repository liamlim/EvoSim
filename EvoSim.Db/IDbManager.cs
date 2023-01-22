namespace EvoSim.Db;

public interface IDbManager<TDomain, TDb>
{
    public void InsertOne(TDomain item);

    public void DeleteOne(Guid id);

    public TDomain GetOne(Guid id);
}
