// See https://aka.ms/new-console-template for more information



StreamReader file = File.OpenText("addresses.csv");
string riga = file.ReadLine(); // scarto la prima riga

while (!file.EndOfStream)
{
    riga = file.ReadLine();
    string[] split = riga.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        string zip = split[5];
        Address a = new Address(name, surname, street,city,province,zip);
        Console.WriteLine(a.ToString());
        Console.WriteLine("---------\n---------");
    }catch(Exception e)
    {
        Console.WriteLine(e.ToString());
    }
    finally
    {
        file.Close();
    }
       
        
    

}
