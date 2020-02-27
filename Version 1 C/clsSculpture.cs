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

        public override void EditDetails()
        {
            if (_SculpDialog == null)
            {
                _SculpDialog = new frmSculpture();
            }
            _SculpDialog.SetDetails(_Name, _Date, _Value, _Weight, _Material);
            if (_SculpDialog.ShowDialog() == DialogResult.OK)
            {
                _SculpDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Weight, ref _Material);
            }
        }
    }
}
