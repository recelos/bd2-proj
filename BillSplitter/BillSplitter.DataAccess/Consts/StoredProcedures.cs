namespace BillSplitter.DataAccess.Consts;

internal static class StoredProcedures
{
  public const string GetUsersPassword = "get_users_password";
  public const string GetUserByUsername = "get_user_by_username";
  public const string GetUsersGroups = "get_user_groups";
  public const string GetReceiptsInGroup = "get_receipts_in_group";
  public const string GetUsersInGroup = "get_users_in_group";
  public const string GetUserDebt = "get_user_debt";
  public const string GetUsersInReceipt = "get_users_in_receipt";
  public const string AddNewGroup = "add_new_group";
  public const string AddNewReceipt = "add_new_receipt";
  public const string AddUserToReceipt = "add_user_to_receipt";
  public const string AddUserToGroup = "add_user_to_group";
  public const string CheckIfOwner = "check_if_owner";
  public const string RemoveReceiptFromGroup = "remove_receipt_from_group";
  public const string RemoveUserFromGroup = "remove_user_from_group";
  public const string GetGroupOwnerName = "get_group_owner_name";
}