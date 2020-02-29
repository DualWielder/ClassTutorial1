using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static frmSculpture _SculpDialog;

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            if (_SculpDialog == null)
            {
                _SculpDialog = new frmSculpture();
            }
            _SculpDialog.SetDetails(this);
        }
    }
}
