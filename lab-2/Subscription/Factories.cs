using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription
{
    public interface ISubscriptionFactoryMethod
    {
        public Subscription CreateSubscription(string catalog);
    }


    public class WebSite : ISubscriptionFactoryMethod
    {
        public Subscription CreateSubscription(string catalog)
        {
            Subscription product;
            if (catalog == "ForEducation")
            {
                product = new EducationalSubscription();

            }else if(catalog == "ForPremium")
            {
                product = new PremiumSubscription();
            }
            else{
                
                product = new DomesticSubscription();
            }

            return product;
        }
    }

    public class MobileApp : ISubscriptionFactoryMethod
    {
        public Subscription CreateSubscription(string catalog)
        {
            Subscription product;
            if (catalog == "TouchEducationButton")
            {
                product = new EducationalSubscription();

            }
            else if (catalog == "TouchPremuiumButton")
            {
                product = new PremiumSubscription();
            }
            else
            {

                product = new DomesticSubscription();
            }

            return product;
        }
    }

    public class ManagerCall : ISubscriptionFactoryMethod
    {
        public Subscription CreateSubscription(string catalog)
        {
            Subscription product;
            if (catalog == "Call911")
            {
                product = new EducationalSubscription();

            }
            else if (catalog == "Call1337")
            {
                product = new PremiumSubscription();
            }
            else
            {

                product = new DomesticSubscription();
            }

            return product;
        }
    }
}
