// See https://aka.ms/new-console-template for more information
class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public int Zip { get; set; }

    public Address(string name, string surname, string street, string city, string province, int zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }
    //public Address() { }

    public override string ToString()
    {
        string text = "";
        text += $"Name: {Name} \nSurname: {Surname} \nStreet: {Street} \nCity: {City}  \nProvince: {Province} \nZip: {Zip}";
        return text;
    }
}