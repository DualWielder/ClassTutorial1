using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmSculpture : Version_1_C.frmWork
    {

        
        public frmSculpture()
        {
            InitializeComponent();
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsSculpture lcWork = (clsSculpture)_Work;
            txtWeight.Text = Convert.ToString(lcWork.Weight);
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            base.pushData();
            clsSculpture lcWork = (clsSculpture)_Work;
            lcWork.Weight = Convert.ToSingle(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

