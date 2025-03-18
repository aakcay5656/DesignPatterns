using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlays;

        public VideoStorage(Compressors compressor,Overlays overlay = Overlays.None )
        {
            _compressor = compressor;
            _overlays = overlay;

        }

        public void SetCompressor(Compressors compressor) { 
            _compressor= compressor;
        }
        public Compressors GetCompressor() { 
            return _compressor;
        }
        public Overlays GetOverlay() {
            return _overlays;
        }

        public void SetOverlay(Overlays overlay) { 
            _overlays= overlay;
        }

        public void Store(string filename)
        {
            if (_compressor == Compressors.MOV)
            {}
            else if(_compressor == Compressors.WEBM) { }
            else if(_compressor == Compressors.MP4){ }



            if (_overlays == Overlays.Blur)
            {
                
            }
            else if (_overlays == Overlays.Blur)
            {
                 
            }
        }
    }
}
