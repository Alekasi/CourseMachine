using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using courseBackGround.parameter;

namespace courseBackGround.child
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ichild" in both code and config file together.
    [ServiceContract]
    public interface Ichild
    {
        [OperationContract]
        List<childClass> readString(string parent);

        [OperationContract]
        List<childClass> read(Guid parent);

        [OperationContract]
        string createString(string parentId, string name, string user);

        [OperationContract]
        string create(childCreate user);

        [OperationContract]
        string updateString(string childId, string name, string user, string parentId);

        [OperationContract]
        string update(childUpdater child);

        [OperationContract]
        string deleteString(string childId, string user);

        [OperationContract]
        string delete(childDelete use);

        [OperationContract]
        string deleteAllString(string parentId, string user);

        [OperationContract]
        string deleteAll(childDeleteAll use);

        //  Settings

        //  CreateOptions is called internally when new child is created

        [OperationContract]
        childOptions readOptions(Guid child, Guid user);

        [OperationContract]
        string updateOptions(childOptions options);

        //  Cant be called externally
        //[OperationContract]
        //string deleteOptions(Guid child, Guid user);
    }

    [DataContract]
    public class childClass
    {
        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public List<parameterClass> parameter { get; set; }

        [DataMember]
        public childOptions options { get; set; }
    }

    [DataContract]
    public class childUpdater
    {
        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid userId { get; set; }

        [DataMember]
        public Guid parentId { get; set; }
    }

    [DataContract]
    public class childCreate
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid userId { get; set; }
    }

    [DataContract]
    public class childDelete
    {
        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

    [DataContract]
    public class childDeleteAll
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

    //  Settings

    [DataContract]
    public class childOptions
    {
        [DataMember]
        public Guid childId { get; set; }

        [DataMember]
        public Guid user { get; set; }

        [DataMember]
        public DateTime releaseDate { get; set; }

        [DataMember]
        public int releaseDates { get; set; }
    }
}
