using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner.PortScanning
{
    public class Port
    {
        public Port(string name, int portNumber)
        {
            this.Validate(name, portNumber);

            this.Name = name;
            this.PortNumber = portNumber;
        }

        public string Name { get; private set; }

        public int PortNumber { get; private set; }

        public bool Open { get; set; } = false;

        public Port UpdateName(string name) 
        {
            this.ValidateName(name);
            this.Name = name;
            return this;
        }

        public Port UpdatePortNumber(int portNumber)
        {
            this.ValidatePortNumber(portNumber);
            this.PortNumber = portNumber;
            return this;
        }

        private void Validate(string name, int portNumber)
        {
            this.ValidateName(name);
            this.ValidatePortNumber(portNumber);
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidPortScanningException();
            }            
        }

        private void ValidatePortNumber(int portNumber)
        {
            if(portNumber > 47823 || portNumber < 1)
            {
                throw new InvalidPortScanningException();
            }
        }
    }
}
