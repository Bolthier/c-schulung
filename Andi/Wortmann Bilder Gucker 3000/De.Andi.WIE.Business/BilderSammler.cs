﻿namespace De.Andi.WIE.Business
{
    public class BilderSammler
    {
        public event Action<string> IchScanneGeradeEinVerzeichnis;
        public string Verzeichnis { get; set; } = @"t:\";

        public List<FileInfo> Bilders { get; private set; } = new List<FileInfo>();

        public String[] WurzelVerzeichnisse { 
            get
            {
                return DriveInfo.GetDrives().Select(x=>@$"{x}").ToArray();
            } 
        }

        public void Start()
        {
            Bilders.Clear();
            LeseVerzeichnis(new DirectoryInfo(Verzeichnis));
        }

        protected virtual void LeseVerzeichnis(DirectoryInfo dir)
        {
            IchScanneGeradeEinVerzeichnis?.Invoke(dir.FullName);
            Bilders.AddRange(dir.GetFiles()
                .Where(x => x.Extension == ".jpg" || x.Extension == ".png" || x.Extension == ".gif")
                .ToList());

            foreach (var d in dir.GetDirectories())
            {
                try
                {
                    LeseVerzeichnis (d);  //REKURSION
                }
                catch (Exception)
                {
                }
            }
        }


    }
}