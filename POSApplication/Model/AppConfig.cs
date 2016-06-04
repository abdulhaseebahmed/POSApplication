using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Model
{
    static class AppConfig
    {
        public static string loggedInUserName = "";
        public static string loggedInUserRole = "";
        public static int loggedInUserID;
        public static DateTime loginTime;
        public static int TerminalID = 1;
        public static string imagefile = "";
        public static string businessSlogan = "";
        public static string bussinessname = "";
        public static DateTime ReportCriteria_FromDate;
        public static DateTime ReportCriteria_ToDate;
        public static String PrinterType;
        public static String MacAddress;
    }
}
