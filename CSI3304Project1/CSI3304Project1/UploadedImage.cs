using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI3304Project1
{
    class UploadedImage
    {
        private int imageId;
        private string imageName;
        private string uploadDate;
        private string provider;
        private string status;
        private byte[] imageFile;

        public UploadedImage()
        {
            imageId = 0;
            imageName = "name";
            uploadDate = "01/01/1900";
            provider = "provider";
            status = "new";
        }

        public void setImageID(int input)
        {
            imageId = input;
        }

        public void setImageName(string input)
        {
            imageName = input;
        }

        public void setUploadDate(string input)
        {
            uploadDate = input;
        }

        public void setProvider(string input)
        {
            provider = input;
        }

        public void setStatus(string input)
        {
            status = input;
        }

        public void setImageFile(byte[] input)
        {
            imageFile = input;
        }

        public int getImageID()
        {
            return imageId;
        }

        public string getImageName()
        {
            return imageName;
        }

        public string getUploadDate()
        {
            return uploadDate;
        }

        public string getProvider()
        {
            return provider;
        }

        public byte[] getImageFile()
        {
            return imageFile;
        }
    }
}
