using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour2.Settings;

namespace Tour2.ComponentHelper
{
    public  class NavigateHelper
    {
        public static void WebSite(String url)
            {
            ObjectRepository.Driver.Navigate().GoToUrl(url);

            }
    }
}
