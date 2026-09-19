namespace OOP_02
{
    #region  DeliveryAddress Struct
    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //    public int BuildingNumber;
    //    public DeliveryAddress(string city, string street, int buildingNumber)
    //    {
    //        City = city;
    //        Street = street;
    //        BuildingNumber = buildingNumber;
    //    }

    //    public string GetFullAddress()
    //    {
    //        return $"BuildingNumber: {BuildingNumber} Street: {Street} City: {City}";
    //    }
    //}
    #endregion
    #region Shipment Class
    //public class Shipment
    //{
    //    private string trackingCode;
    //    private string description;
    //    private double weight;
    //    private decimal deliveryFee;

    //    public DeliveryAddress Destination { get; set; }

    //    public string TrackingCode
    //    {
    //        get { return trackingCode; }
    //    }

    //    public string Description
    //    {
    //        get { return description; }
    //        set
    //        {
    //            if (!string.IsNullOrWhiteSpace(value))
    //            {
    //                description = value;
    //            }
    //        }
    //    }

    //    public double Weight
    //    {
    //        get { return weight; }
    //        set
    //        {
    //            if (value > 0)
    //            {
    //                weight = value;
    //            }
    //        }
    //    }

    //    public decimal DeliveryFee
    //    {
    //        get { return deliveryFee; }
    //        private set
    //        {
    //            if (value > 0)
    //            {
    //                deliveryFee = value;
    //            }
    //        }
    //    }

    //    public virtual decimal EstimatedCost
    //    {
    //        get { return DeliveryFee + (decimal)(Weight * 5); }
    //    }

    //    public Shipment() { }

    //    public Shipment(string trackingCode)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //        {
    //            Console.WriteLine("cannot be empty");
    //        }

    //        this.trackingCode = trackingCode;
    //        description = "Unknown";
    //        weight = 1;
    //        deliveryFee = 50;
    //        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    //    }

    //    public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //        {
    //            throw new ArgumentException("Tracking code cannot be empty.");
    //        }

    //        this.trackingCode = trackingCode;
    //        this.description = "Unknown";
    //        this.weight = 1;
    //        this.deliveryFee = 50;

    //        if (!string.IsNullOrWhiteSpace(description))
    //            this.description = description;

    //        if (weight > 0)
    //            this.weight = weight;

    //        if (deliveryFee > 0)
    //            this.deliveryFee = deliveryFee;

    //        Destination = destination;
    //    }

    //    public void UpdateDeliveryFee(decimal newFee)
    //    {
    //        if (newFee > 0)
    //        {
    //            DeliveryFee = newFee;
    //        }
    //    }

    //    public virtual void PrintShipment()
    //    {
    //        Console.WriteLine("Tracking Code: " + TrackingCode);
    //        Console.WriteLine("Description: " + Description);
    //        Console.WriteLine("Weight: " + Weight + " KG");
    //        Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
    //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
    //        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    //    }
    //}
    #endregion
    #region Inheritance
    //public class StandardShipment : Shipment
    //{
    //    // Constructor Chaining
    //    public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //    }

    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine(" tandard Shipment");
    //        base.PrintShipment();
    //    }
    //}


    //public class ExpressShipment : Shipment
    //{
    //    public decimal ExtraFee { get; set; }

    //    public override decimal EstimatedCost
    //    {
    //        get { return base.EstimatedCost + ExtraFee; }
    //    }

    //    public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //        ExtraFee = extraFee >= 0 ? extraFee : 0;
    //    }

    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine("Express Shipment");
    //        Console.WriteLine("Extra Fee: " + ExtraFee + " EGP");
    //        base.PrintShipment();
    //    }
    //}

    //public class InternationalShipment : Shipment
    //{
    //    public string DestinationCountry { get; set; }
    //    public decimal CustomsFee { get; set; }

    //    public override decimal EstimatedCost
    //    {
    //        get { return base.EstimatedCost + CustomsFee; }
    //    }

    //    public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //        DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;
    //        CustomsFee = customsFee >= 0 ? customsFee : 0;
    //    }

    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine("International Shipment");
    //        Console.WriteLine("Destination Country: " + DestinationCountry);
    //        Console.WriteLine("Customs Fee: " + CustomsFee + " EGP");
    //        base.PrintShipment();
    //    }
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 Question1
            ////a)Class is a refernce type data type that supports inheritance and usualy used for the big data
            ////b)Struct is a value type data type that doesn't supports inheritance and usualy used for the small data
            #endregion
            #region Part1 Question2
            ////a)The paret class is Shipment
            ////b)The child class is ExpressShipment
            ////c)It inherits the property TrackingCode(besides the baisc object functions)
            ////d)The inheritance reduces repition which reduces bugs and makes the code easier to mantain instead of having only a base class
            #endregion
        }
    }
}
