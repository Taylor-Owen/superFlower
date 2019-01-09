using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace superflower
{
    class SMBRom
    {
        public byte[] data;
        public string fileName, filePath;

        public bool romLoaded;

        public bool openRomCheck(string path)
        {
            long length = new System.IO.FileInfo(path).Length;
            if (length != Constants.SMB_Filesize1)
                return false;

            return true;
        }
    }
}
