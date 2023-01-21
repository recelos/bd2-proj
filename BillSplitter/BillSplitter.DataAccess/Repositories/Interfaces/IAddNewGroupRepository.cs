namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IAddNewGroupRepository
{
  public bool TryAddGroup(int userId, string groupName);
}