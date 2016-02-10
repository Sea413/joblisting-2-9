using System.Collections.Generic;

namespace Openings.Objects
{
  public class Contact
  {
      private string _name;
      private string _phone;
      private string _email;

  public  Contact (string name, string phone, string email)
  {
    this._name = name;
    this._phone = phone;
    this._email = email;
  }
  public string GetName(string newName)
  {
    return this._name;
  }
  public void SetName(string newName)
  {
    this._name = newName;
  }
  public string GetPhone(string newPhone)
  {
    return this._phone;
  }
  public void SetPhone(string newPhone)
  {
    this._phone = newPhone;
  }
  public string GetEmail(string newEmail)
  {
    return this._email;
  }
  public void SetEmail(string newEmail)
  {
    this._email = newEmail;
  }
}
}
