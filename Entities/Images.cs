using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Images
    {
        public byte[]? ImageData { get; set; }

        public int ImageId { get; set; }
        public string? ImageName { get; set; }
        public string? ImageContentType { get; set; }
    }
}
