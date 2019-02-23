using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tour2.ComponentHelper;

namespace Tour2.Log4net
{
    [TestClass]
  public  class TestLogger
    {
        [TestMethod]
        public void TestLog4net()
        {
        //    var patterLayout = new PatternLayout();
        //    patterLayout.ConversionPattern = "%date{dd MMM yyyy_HH:mm:ss} [%level]- [%class] - [%method]  %message%n";
        //    patterLayout.ActivateOptions();

        //    var consoleAppender = new ConsoleAppender()
        //    {
        //        Name = "ConsoleAppender",
        //        Layout = patterLayout,
        //        Threshold = Level.All
        //    };
        //    consoleAppender.ActivateOptions();
        //    BasicConfigurator.Configure(consoleAppender);
            ILog logger = Log4NetHelper.GetXmlLogger(typeof(TestLogger));

            logger.Debug("This is debug log info");
            logger.Error("This is Error log info");
            logger.Warn("This is Warn log info");
            logger.Error("This is Error log info");
            logger.Fatal("This is Fatal log info");


        }
    }
}
