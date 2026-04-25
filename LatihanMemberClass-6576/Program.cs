using LatihanMemberClass_6576;

class Program
{
    static void Main(string[] args)
    {
        planeTicket ticket1 = new planeTicket();
        ticket1.origin = "JOGJA";
        ticket1.destination = "PKU";
        ticket1.cost = 100;
        ticket1.currency = "USD";

        planeTicket ticket2 = new planeTicket();
        ticket2.origin = "JKT";
        ticket2.destination = "PKU";
        ticket2.cost = 750000;
        ticket2.currency = "IDR";

        ticket1.PrintSummary();
        ticket2.PrintSummary();
    }
}