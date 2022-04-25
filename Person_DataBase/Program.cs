Person person = GetPerson();

string phoneNumber = person?.Contacts?.PhoneNumber ?? "нет данных";

Console.WriteLine(phoneNumber);


static Person GetPerson()
{
    Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "123456789" } };
    return person;
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MidName { get; set; }
    public Contacts Contacts { get; set; }

    public string GetFullName()
    {
        string fullName = $"{FirstName} {LastName} {MidName}";
        return fullName;
    }

    public string GetPhoneNumber()
    {
        string phoneNumber = Contacts.PhoneNumber;
        return phoneNumber;
    }
}

public class Contacts
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}