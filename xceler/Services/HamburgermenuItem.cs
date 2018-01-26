using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xceler.Model;

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
                        MenuName = "Refer Patient",
                        MenuIcon = "referMenu",
                       // Navigation = typeof(ReferPatient)

                    },
                    new Hamburgermenu{
                        MenuName = "Referral History",
                        MenuIcon = "historyMenu",
                       // Navigation = typeof(ReferalHistoryPage)

                    },
                    new Hamburgermenu{
                        MenuName = "Feed back",
                        MenuIcon = "viewMediaMenu",
                      //  Navigation = typeof(FeedBack)

                    },
                    new Hamburgermenu{
                        MenuName = "Edit Profile",
                        MenuIcon = "profileEditMenu",
                      //  Navigation = typeof(EditProfile)

                    }


                     };
            return list;

        }
    }
}
