using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyowrdDemo
{
    public static class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 0)
            {
                return true;
            }

            return false;
        }
        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }
}
