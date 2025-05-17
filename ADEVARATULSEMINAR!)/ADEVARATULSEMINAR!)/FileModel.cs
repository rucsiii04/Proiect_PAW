using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar10
{
    internal class FileModel
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public DateTime LastModified { get; set; }
        public int Size {  get; set; }
    }
}
