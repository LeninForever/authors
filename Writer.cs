using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    public class Writer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Image { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string Gender { get; set; }
        public string BirthPlace { get; set; }
        public string JobTitle { get; set; }

        public Writer()
        {

        }
        public Writer(WriterJson writerJson)
        {
            string[] firstAndLastName = writerJson.Name.Split(' ');

            FirstName = firstAndLastName[0];
            LastName = firstAndLastName[1];

            using (WebClient client = new WebClient())
            {
                Image = client.DownloadData(writerJson.image.url);
            }
            BirthDate = Convert.ToDateTime(writerJson.birthDate);
            try
            {
            DeathDate = Convert.ToDateTime(writerJson.deathDate);

            }
            catch (Exception)
            {
                DeathDate = null;
            } 
            Gender = writerJson.gender;
            BirthPlace = writerJson.birthPlace;
            JobTitle = writerJson.jobTitle;
        }

    }
}
