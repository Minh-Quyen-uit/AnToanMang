using Bunifu.UI.Winforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnATM
{
    public partial class ProjectATM : MetroFramework.Forms.MetroForm
    {
        public ProjectATM()
        {
            InitializeComponent();
        }
        #region Btn_Click

        private void PlayFairBtn_Click(object sender, EventArgs e)
        {
            PlayFairForm playFairForm = new PlayFairForm();
            playFairForm.Show();

        }

        private void RSABtn_Click(object sender, EventArgs e)
        {
            RSAForm rsaForm = new RSAForm();
            rsaForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Red;
            CloseBtn.ForeColor = Color.White;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.White;
            CloseBtn.ForeColor = Color.Black;
        }

        
    }
}
