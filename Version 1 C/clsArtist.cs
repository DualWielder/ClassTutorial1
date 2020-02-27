using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {

        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;

        private readonly static frmArtist _ArtistDialog = new frmArtist();

        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public decimal TotalValue { get => _TotalValue; set => _TotalValue = value; }
        public clsWorksList WorksList { get => _WorksList; set => _WorksList = value; }
        public clsArtistList ArtistList { get => _ArtistList; set => _ArtistList = value; }

        public clsArtist(clsArtistList prArtistList)
        {
            WorksList = new clsWorksList();
            ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            _ArtistDialog.SetDetails(this);
            TotalValue = WorksList.GetTotalValue();
        }

       

       

    }
}
