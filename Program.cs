// See https://aka.ms/new-console-template for more information

StreamReader file;
bool flag = true;
List<Address> addresses = new List<Address>();

try
{
   file  =  File.OpenText("addresses.csv");

}
catch (Exception e)
{
    Console.WriteLine(e.Message.ToString());   
    flag = false;
    File.Create("error.txt").Close();
    file = File.OpenText("error.txt");

}




if (flag)
{

    string riga = file.ReadLine(); // scarto la prima riga


    while (!file.EndOfStream)
    {
        riga = file.ReadLine();
        string[] split = riga.Split(',');

        string name;
        string surname;
        string street;
        string city;
        string province;
        string zip;

        if (split.Count() == 6)
        {
            bool isValid = true;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] == "")
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                name = split[0];
                surname = split[1];
                street = split[2];
                city = split[3];
                province = split[4];
                zip = split[5];

                Address a = new Address(name, surname, street, city, province, zip);
                addresses.Add(a);

                Console.WriteLine(a.ToString());
                Console.WriteLine("---------\n---------");
            }else
            {
                Console.WriteLine("Indirizzo con dati mancanti");
                Console.WriteLine("---------\n---------");
            }
            

            
        }
        else if(split.Count() == 7)
        {
            name = split[0] + " " + split[1];
            surname = split[2];
            street = split[3];
            city = split[4];
            province = split[5];
            zip = split[6];

            Address a = new Address(name, surname, street, city, province, zip);
            addresses.Add(a);

            Console.WriteLine(a.ToString());
            Console.WriteLine("---------\n---------");
        }
        else
        {
            Console.WriteLine("Indirizzo con dati mancanti");
            Console.WriteLine("---------\n---------");
        }

    }



    file.Close();
}


