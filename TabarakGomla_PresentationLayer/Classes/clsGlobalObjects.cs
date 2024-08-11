using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabarakGomla_BusinessLayer;

namespace TabarakGomla_PresentationLayer.Classes
{
    public static class clsGlobalObjects
    {

        public static frmMainScreen mainScreen = new frmMainScreen();

        public static clsUsers currentUser = clsUsers.FindByUserID(1);

    }
}
