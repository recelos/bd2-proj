﻿namespace BillSplitter.DataAccess.Models;

public class User
{
  public int UserId { get; set; }
  public string Username { get; set; }
  public string Password { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int UserType { get; set; }
  public int IdCountry { get; set; }
  public DateTime CreationDate { get; set; }
}