using System.Linq.Expressions;

namespace De.Tobias.WIE.Business
{
    public class BilderSammler
    {
        public string Verzeichnis { get; set; } = @"z:\";

        public List<FileInfo> Bilders { get; private set; } = new List<FileInfo>();

        public string[] WurzelVerzeichnis { 
            get
            {
                return DriveInfo.GetDrives().Select(x => @$"{x}").ToArray();
            }
        }

        public void Start()
        {
            Bilders.Clear();
            LeseVerzeichnis(new DirectoryInfo(Verzeichnis));
        }

        protected virtual void LeseVerzeichnis(DirectoryInfo dir)
        {
            Bilders.AddRange(dir.GetFiles()
                .Where(x => x.Extension == ".jpg" || x.Extension == ".png" || x.Extension == ".gif")
                .ToList());

            foreach (var d in dir.GetDirectories())
            {
                try
                {
                    LeseVerzeichnis(d); //Rekursion
                }
                catch(Exception)
                { 
                }
            }
        }

    }
}
