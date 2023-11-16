using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    internal class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _sharedFolder;
        private Employee employee;
        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }
        public void ReadWriteToSharedFolder()
        {
            if(employee.Role == "Admin")
            {
                _sharedFolder = new SharedFolder();
                _sharedFolder.ReadWriteToSharedFolder();

            }
            else
            {
                Console.WriteLine("you do not have access to this folder");
            }
        }
    }
}
