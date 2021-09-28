using System;
using BitMiracle.LibTiff.Classic;
    
    namespace RGIS.GeoTIFF
{
    public class FileContent
    {
        private Tiff _fileData;

        private string _path;

        private bool _HasGeoKeyDirectoryTag = false; 
        
        public FileContent(string url)
        {
            _fileData = Tiff.Open(url, "w");
            


            if (_fileData == null)
            {
                throw new ArgumentException("No File (" + url + ") found");
            }
            
            _path = url;

            CheckGeoTIFF();
            
            System.Console.WriteLine(_fileData.FileName());
            
            _fileData.Close();
        }

        private bool CheckGeoTIFF()
        {
            //Requirements based on Information found in: http://docs.opengeospatial.org/is/19-008r4/19-008r4.html#_underlying_tiff_requirements
            // Requirement 1.1
            if (!CheckTIFFCompliancy())
            {
                return false;
            }
            
            // Requirement 1.2
            if (!CheckGeoKeyDirecctoryTag())
            {
                return false;
            }

            return true;
        }

        public Tiff GetFileData()
        {
            return _fileData;
        }

        public string GetPath()
        {
            return _path;
        }

        private bool CheckTIFFCompliancy()
        {
            return true;
        }

        private bool CheckGeoKeyDirecctoryTag()
        {

            FieldValue[] geoTag = _fileData.GetField(TiffTag.GEOTIFF_GEOKEYDIRECTORYTAG);
            _HasGeoKeyDirectoryTag = true;
            return true;
        }
    }
}