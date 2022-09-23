// See https://aka.ms/new-console-template for more information



StreamReader file = File.OpenText("addresses.csv");
string riga = file.ReadLine(); // scarto la prima riga

while (!file.EndOfStream)
{
     riga = file.ReadLine();
    string[] split = riga.Split(',');
    if (split.Count() == 6)
    {
        Address a = new Address(split[0], split[1], split[2], split[3], split[4], Convert.ToInt32(split[5]));
        Console.WriteLine(a.ToString());
        Console.WriteLine("---------\n---------");
    }

}
 file.Close();