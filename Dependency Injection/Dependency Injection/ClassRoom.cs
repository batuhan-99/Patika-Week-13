using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

       
        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

       
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
