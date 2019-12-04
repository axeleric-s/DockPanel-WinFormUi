using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsCtrlLib;

namespace DockPanel.WinFormUi
{
    public partial class DockContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        UserControl FormControl = new UserControl();

        public DockContent()
        {
        }

        public DockContent(object sender, EventArgs e)
        {
            new DockContent(sender,e);
            this.FormControl = (ControlSelect(sender, e));
            InitializeComponent();
        }

        public DockContent(
            IContainer components, UserControl formControl)
        {
            this.components = components;
            FormControl = formControl ?? throw new ArgumentNullException(nameof(formControl));
        }

        private UserControl ControlSelect(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Name)
            {
                case "Tool":
                    return new ToolFormCtrl();
                case "ToolBox":
                    return new ToolBoxFormCtrl();
                case "TaskList":
                    return new TaskListFormCtrl();
                case "Solusion":
                    return new SolutionFormCtrl();
                case "Property":
                    return new PropertyFormCtrl();
                case "Output":
                    return new OutputFormCtrl();
                case "Dock":
                    return new DockFormCtl();
                default:
                    return new SplashFormCtrl();
            }
        }

        private void DockContent_Load(object sender, EventArgs e)
        {

        }
    }
}
