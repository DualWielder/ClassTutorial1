using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float theWeight;
        private string theMaterial;

        [NonSerialized()]
        private static frmSculpture sculpDialog;

        public override void EditDetails()
        {
            if (sculpDialog == null)
            {
                sculpDialog = new frmSculpture();
            }
            sculpDialog.SetDetails(_Name, theDate, theValue, theWeight, theMaterial);
            if (sculpDialog.ShowDialog() == DialogResult.OK)
            {
                sculpDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWeight, ref theMaterial);
            }
        }
    }
}
