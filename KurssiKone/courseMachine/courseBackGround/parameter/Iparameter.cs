using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace courseBackGround.parameter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iparameter" in both code and config file together.
    [ServiceContract]
    public interface Iparameter
    {
        [OperationContract]
        List<parameterClass> readString(string childId);

        [OperationContract]
        List<parameterClass> read(Guid childId);

        [OperationContract]
        string createString(string type, string childId, string creator);

        [OperationContract]
        string create(parametercreate use);

        [OperationContract]
        string updateString(string childId, string parameterId, string creator, string type, string value, string order, string status);

        [OperationContract]
        string update(List<parameterClass> use);

        [OperationContract]
        string deleteString(string creator, string parameterId);

        [OperationContract]
        string delete(parameterDelete use);

        [OperationContract]
        string deleteAllString(string creator, string childId);

        [OperationContract]
        string deleteAll(parameterDeleteAll use);

    }

    [DataContract]
    public class parameterClass
    {
        [DataMember]
        public Guid parameterId { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public string type { get; set; }

        [DataMember]
        public string value { get; set; }

        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public string order { get; set; }

        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string additional_1 { get; set; }

        [DataMember]
        public string additional_2 { get; set; }

        [DataMember]
        public string additional_3 { get; set; }

        [DataMember]
        public string additional_4 { get; set; }
    }

    [DataContract]
    public class parametercreate
    {
        [DataMember]
        public string type { get; set; }

        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public Guid creator { get; set; }
    }

    [DataContract]
    public class parameterUpdate
    {
        [DataMember]
        public Guid parameterId { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public string type { get; set; }

        [DataMember]
        public string value { get; set; }

        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public string order { get; set; }
    }

    [DataContract]
    public class parameterDelete
    {
        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public Guid parameterId { get; set; }
    }

    [DataContract]
    public class parameterDeleteAll
    {
        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public Guid childId { get; set; }
    }
}

