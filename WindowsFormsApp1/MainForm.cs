using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            xtraTabbedMdiManager1.MultiLine = DefaultBoolean.True;
        }

        public void FormCall(Type formType, params object[] param)
        {
            if (formType == null) return;
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (page.MdiChild.GetType() == formType)
                {
                    if (param.Length == 1)
                    {
                        if (page.MdiChild is Split)
                        {
                            xtraTabbedMdiManager1.SelectedPage = page;
                            return;
                        }
                    }
                    else if (param.Length == 2)
                    {
                        if (page.MdiChild is Directories &&
                             (((Directories)page.MdiChild).FormType == Directories.RequestType.Days && !(bool)param[0] ||
                              ((Directories)page.MdiChild).FormType == Directories.RequestType.Broker && (bool)param[0]) &&
                             param[1] is int)
                        {
                            //((Directories)page.MdiChild).FocusRowByIdRequest((int)param[1]);
                            xtraTabbedMdiManager1.SelectedPage = page;
                            return;
                        }
                        //((Directories)page.MdiChild).FocusRowByIdRequest((int)param[1]);
                        //xtraTabbedMdiManager1.SelectedPage = page;
                        //return;
                    }
                }
            }

           // SplashScreenManager.ShowForm(this, typeof(WaitingForm1), true, true);

            var fm = Activator.CreateInstance(formType, param);
            var propInfo = formType.GetProperty("MdiParent");
            propInfo?.SetValue(fm, this, null);
            var methodInfo = formType.GetMethod("Show", new Type[] { });
            methodInfo?.Invoke(fm, null);

            //SplashScreenManager.CloseForm();
        }
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 1);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Purchase));
        }

        private void Split_ItemChanged(object sender, EventArgs e)
        {

        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 2);
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 3);
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 4);
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 5);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 6);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 7);
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 8);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 9);
        }
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 10);
        }

        private void navItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Directories), 1);
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCall(typeof(Stock));
        }
    }
}
