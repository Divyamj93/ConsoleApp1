using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface MobileAuthenticationInterface
    {
        bool authenticate();
    }
    public class FaceRecognitionAuthentication : MobileAuthenticationInterface
    {
        public bool authenticate()
        {
            return true;
        }
    }
    public class FingerPrintAuthentication : MobileAuthenticationInterface
    {
        public bool authenticate()
        {
            return true;
        }
    }
    public class PasswordAuthentication : MobileAuthenticationInterface
    {
        public bool authenticate()
        {
            return true;
        }
    }
}
