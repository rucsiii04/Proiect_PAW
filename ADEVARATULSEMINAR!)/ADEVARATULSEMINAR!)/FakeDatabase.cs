using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar10
{
    internal class FakeDatabase
    {
        public static List<FileModel> Files = new List<FileModel>() {
            new FileModel(){
                Name="text",
                Extension="txt",
                Size=4096,
                LastModified=DateTime
            }
        };

    }
}
