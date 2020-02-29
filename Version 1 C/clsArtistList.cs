using System;
using System.Collections.Generic;


namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList<string, clsArtist>

    {
        private const string _FileName = "gallery.xml";

        public void EditArtist(clsArtist prArtist)
        {
            prArtist.EditDetails();
        }
       
        public void NewArtist()
        {
            clsArtist lcArtist = new clsArtist(this);
            if (lcArtist.Name != "")
            {
                Add(lcArtist.Name, lcArtist);
            }

        }
        
        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        public void Save()
        {
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch { }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList = new clsArtistList();

            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }

            catch { }

            return lcArtistList;
        }

    }

}
