using System;

namespace RGIS.GeoTIFF
{
    public class InformationProvider
    {
        private FileContent _fileContent;
        
        public InformationProvider(FileContent rawData)
        {
            _fileContent = rawData;
            ReadData();
        }

        private GeoTIFFInformation ReadData()
        {
            GeoTIFFInformation info = new GeoTIFFInformation();

            return info;
        }
    }
}