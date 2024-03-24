namespace Subscription
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; protected set; }
        public DateTime MinSubscriptionPeriod { get; protected set;}
        public List<string> Channels { get; protected set; }

        public Subscription(decimal monthlyFee, DateTime minSubscriptionPeriod, List<string> channels)
        {
            MonthlyFee = monthlyFee;
            MinSubscriptionPeriod = minSubscriptionPeriod;
            Channels = channels;
        }

        public abstract void GetStatus();
    }

    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(300, DateTime.Now.AddDays(25), new List<string> { "Channel 1", "Channel 2", "Channel 3", "Channel 4"})
        {
        }

        public override void GetStatus()
        {
            Console.WriteLine($"\nMonthly fee of domestic subscription - {MonthlyFee}");
            Console.WriteLine($"Min subscription period - {MinSubscriptionPeriod}");
            Console.WriteLine("Allowed channels:");
            for (int i = 0; i < Channels.Count; i++)
            {
                Console.WriteLine($"{Channels[i]}");
            }
        }
    }

    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(200, DateTime.Now.AddDays(30), new List<string> { "Channel 1", "Channel 2", "Channel 3", "Channel 4", "Channel 5", "Channel 6"})
        {
        }

        public override void GetStatus()
        {
            Console.WriteLine($"\nMonthly fee of educational subscription - {MonthlyFee}");
            Console.WriteLine($"Min subscription period - {MinSubscriptionPeriod}");
            Console.WriteLine("Allowed channels:");
            for (int i = 0; i < Channels.Count; i++)
            {
                Console.WriteLine($"{Channels[i]}");
            }
        }
    }

    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(400, DateTime.Now.AddDays(35), new List<string> { "Channel 1", "Channel 2", "Channel 3", "Channel 4", "Channel 5", "Channel 6", "Channel 7", "Channel 8", "Channel 9", "Channel 10" })
        {
        }

        public override void GetStatus()
        {
            Console.WriteLine($"\nMonthly fee of premium subscription - {MonthlyFee}");
            Console.WriteLine($"Min subscription period - {MinSubscriptionPeriod}");
            Console.WriteLine("Allowed channels:");
            for (int i = 0; i < Channels.Count; i++)
            {
                Console.WriteLine($"{Channels[i]}");
            }
        }
    }
}
