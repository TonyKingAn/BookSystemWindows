using System;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class CreateUserDialog : Form
    {
        private delegate void SuccessCallBackEventHandler();

        SuccessCallBackEventHandler successCallback;
        public CreateUserDialog(Action callback)
        {
            InitializeComponent();
            if (callback != null)
            {
                successCallback = new SuccessCallBackEventHandler(callback);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
