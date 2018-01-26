using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xceler.Model;
using xceler.View;

namespace xceler.Services
{
    public class HamburgermenuItem
    {

        public List<Hamburgermenu> GetItem()
        {

            var list = new List<Hamburgermenu>
                  {
                    //new Hamburgermenu{
                    //    MenuName = "Insights",
                    //    MenuIcon = "insightMenu",
                    //    Navigation = typeof(LandingPage)

                    //},
                    new Hamburgermenu{
                        MenuName = "Fill Details",
                        MenuIcon = "referMenu",
                        Navigation = typeof(EnterDetails)

                    },
                    new Hamburgermenu{
                        MenuName = "View Details",
                        MenuIcon = "historyMenu",
                       // Navigation = typeof(ReferalHistoryPage)

                    },
                    new Hamburgermenu{
                        MenuName = "Random Json ListView",
                        MenuIcon = "viewMediaMenu",
                      //  Navigation = typeof(FeedBack)

                    }


                     };
            return list;

        }
    }
}
