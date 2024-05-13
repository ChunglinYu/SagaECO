using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaLib
{
    public class PacketAttribute : Attribute
    {
        public int OrderIndex { get; set; }

        public string Encoding { get; set; }

        public bool IsDataSizeVariable { get; set; }

        public bool IsHexCode { get; set; }

        public PacketAttribute()
        {
            Encoding = null;

            IsDataSizeVariable = false;

            IsHexCode = false;
        }
    }
}
