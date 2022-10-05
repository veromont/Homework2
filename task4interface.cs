using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Mountain Montblanc = new Mountain("Mont Blanc");
        River Dnipro = new River("Dnipro");
        Montblanc.GetInformation();
        Dnipro.GetInformation();
        Montblanc.PrintInformation();
        Console.WriteLine();
        Dnipro.PrintInformation();
    }
}

interface IGeographicalObject
{
    int x { get; set; }
    int y { get; set; }
    string name { get; set; }
    string? description { get; set; }
    public void GetInformation();
    public void PrintInformation();
}
class River: IGeographicalObject
{
    public int x { get; set; }
    public int y { get; set; }
    public string name { get; set; }
    public string? description { get; set; }

    double streamSpeed;
    double length;
    public River (string naming)
    {
        name = naming;
        x = 0;
        y = 0;
        description = "";
    }
    public void GetInformation()
    {
        Console.WriteLine("Geographical object: " + name);
        Console.WriteLine();

        Console.WriteLine("Enter latitude coordinate x:");
        int x1;
        string? t = Console.ReadLine();
        if (int.TryParse(t, out x1))
        {
            x = x1;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (int.TryParse(t, out x1) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        x = x1;


        Console.WriteLine("Enter longtitude coordinate x:");
        int y1;
        t = Console.ReadLine();
        if (int.TryParse(t, out y1))
        {
            y = y1;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (int.TryParse(t, out y1) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        y = y1;

        Console.WriteLine("Enter description (optional):");
        t = Console.ReadLine();
        this.description = t;


        Console.WriteLine("Enter stream speed:");
        double s;
        t = Console.ReadLine();
        if (double.TryParse(t, out s))
        {
            streamSpeed = s;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (double.TryParse(t, out s) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        streamSpeed = s;


        Console.WriteLine("Enter length:");
        double l;
        t = Console.ReadLine();
        if (double.TryParse(t, out l))
        {
            length = l;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (double.TryParse(t, out l) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        length = l;
    }

    public void PrintInformation()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Coordinates: " + x + ", " + y);
        Console.WriteLine("Stream speed:  " + streamSpeed + " sm per second");
        Console.WriteLine("Length is: " + length + " km");
        if (description != "")
        {
            Console.WriteLine("Additional information: ");
            Console.WriteLine(description);
        }
    }
}

class Mountain : IGeographicalObject
{
    public int x { get; set; }
    public int y { get; set; }
    public string name { get; set; }
    public string? description { get; set; }

    double peak;
    public Mountain(string naming)
    {
        name = naming;
        x = 0;
        y = 0;
        description = null;
    }
    public void GetInformation()
    {
        Console.WriteLine("Geographical object: " + name);
        Console.WriteLine();
        Console.WriteLine("Enter latitude coordinate x:");
        int x1;
        string? t = Console.ReadLine();
        if (int.TryParse(t, out x1))
        {
            x = x1;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (int.TryParse(t, out x1) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        x = x1;


        Console.WriteLine("Enter longtitude coordinate x:");
        int y1;
        t = Console.ReadLine();
        if (int.TryParse(t, out y1))
        {
            y = y1;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (int.TryParse(t, out y1) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        y = y1;

        Console.WriteLine("Enter description (optional):");
        t = Console.ReadLine();
        description = t;


        Console.WriteLine("Enter elevation:");
        double p;
        t = Console.ReadLine();

        if (double.TryParse(t, out p))
        {
            peak = p;
        }
        else
        {
            Console.WriteLine("Enter eligible value, please: ");
            t = Console.ReadLine();
            while (double.TryParse(t, out p) != true)
            {
                Console.WriteLine("Enter eligible value, please: ");
                t = Console.ReadLine();
            }
        }
        peak = p;
    }
    public void PrintInformation()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Coordinates: " + x + ", " + y);
        Console.WriteLine("Elevation:  " + peak + " m");
        if (description != "")
        {
            Console.WriteLine("Additional information: ");
            Console.WriteLine(description);
        }
    }
}

