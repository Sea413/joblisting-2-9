using System.Collections.Generic;

namespace Openings.Objects
{

  public class Job
  {
      private string _title;
      private string _description;
      private string _salary;
      private object _contact;
      private static List<object> _instances = new List<object> {};

    public Job (string title, string description, string salary, object Contact)
    {
      this._title = title;
      this._description = description;
      this._salary = salary;
      this._contact = Contact;
    }
    public string GetTitle()
    {
      return this._title;
    }
    public void SetTitle(string newTitle)
    {
      this._title = newTitle;
    }

    public string GetDescription()
    {
      return this._description;
    }
    public void SetDescription(string newDescription)
    {
      this._description = newDescription;
    }

    public string GetSalary()
    {
      return this._salary;
    }
    public void SetSalary(string newSalary)
    {
      this._salary = newSalary;
    }
    public object GetContact()
    {
      return this._contact;
    }
    public void SetContact(object newContact)
    {
      this._contact = newContact;
    }
    public static List<object> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
    _instances.Clear();
    }
  }
}
