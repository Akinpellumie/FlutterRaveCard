using Rave;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterRaveCard
{
    public static class Helper
    {

        public static string PbKey = "pass your public key here";
        public static string ScKey = "pass your secret key here";
        public static RaveConfig raveConfig = new RaveConfig(PbKey, ScKey, false);
    }
}
