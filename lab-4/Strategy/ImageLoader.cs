using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageLoader
    {
        private IImageLoading imageLoadingType;

        public void SetImageLoadingStrategy(IImageLoading strategy)
        {
            imageLoadingType = strategy;
        }

        public void ImageLoad(string href)
        {
            imageLoadingType.Load(href);
        }
    }
}
