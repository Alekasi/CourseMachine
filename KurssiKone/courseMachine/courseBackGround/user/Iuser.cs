using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace courseBackGround
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iuser" in both code and config file together.
    [ServiceContract]
    public interface Iuser
    {
        [OperationContract]
        int checkEmail(string email);

        [OperationContract]
        string userRegister(register use);

        [OperationContract]
        string userLogin(login use);
    }

    [DataContract]
    public class register
    {

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string password { get; set; }
    }

    [DataContract]
    public class login
    {
        [DataMember]
        public string user { get; set; }

        [DataMember]
        public string password { get; set; }
    }
}
