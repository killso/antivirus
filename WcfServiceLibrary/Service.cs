using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace WcfServiceLibrary
{
    public class Service : IService
    {
        private ServiceHost service_host = null;
        public void GetData()
        {
            return;
        }
    }
}
