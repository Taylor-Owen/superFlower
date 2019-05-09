namespace superflower
{
    class SMBRom
    {
        public byte[] data;
        public string fileName, filePath;

        public bool romLoaded;

        public bool openRomCheck(string path)
        {
            var length = new System.IO.FileInfo(path).Length;
            return length == Constants.SMB_Filesize1;
        }
    }
}
