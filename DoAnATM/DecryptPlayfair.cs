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
    public partial class DecryptPlayfair : Form
    {
        public DecryptPlayfair(string textDecryt)
        {
            InitializeComponent();
            DecryptionTxt.Text = textDecryt;
        }

        
    }
}
