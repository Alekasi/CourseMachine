using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace courseBackGround.Error
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IerrorHandler" in both code and config file together.
    [ServiceContract]
    public interface IerrorHandler
    {
        [OperationContract]
        void createError(string origin, string message);
    }

    [DataContract]
    public class errorClass{
        [DataMember]
        public Guid errorId { get; set; }

        [DataMember]
        public string origin { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public DateTime dateTime { get; set; }
    }
}
