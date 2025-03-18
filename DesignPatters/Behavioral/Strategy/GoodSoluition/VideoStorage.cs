using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Strategy.GoodSoluition
{
    public class VideoStorage
    {
        private ICompressors _compressor;
        private IOverlays _overlays;

        public VideoStorage(ICompressors compressor, IOverlays overlay )
        {
            _compressor = compressor;
            _overlays = overlay;
        }

        public void SetCompressor(ICompressors compressor)
        {
            _compressor = compressor;
        }
        public ICompressors GetCompressor()
        {
            return _compressor;
        }
        public IOverlays GetOverlay()
        {
            return _overlays;
        }

        public void SetOverlay(IOverlays overlay)
        {
            _overlays = overlay;
        }

        public void Store(string filename)
        {
            _compressor.Compress();
            _overlays.Apply();

            Console.WriteLine("Storing video to " + filename + "." + _compressor);
        }

    }
}
