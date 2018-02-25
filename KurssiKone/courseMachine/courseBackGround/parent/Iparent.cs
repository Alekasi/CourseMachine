using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using courseBackGround.child;

namespace courseBackGround.parent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iparent" in both code and config file together.
    [ServiceContract]
    public interface Iparent
    {
        [OperationContract]
        bool checkString(string name);

        [OperationContract]
        bool check(Guid parentId);
        
        [OperationContract]
        List<parentClass> readString(string id);

        [OperationContract]
        List<parentClass> read(Guid id);

        [OperationContract]
        string createString(string name, string user, string courseId);

        [OperationContract]
        string create(parentCreate parent);

        [OperationContract]
        string updateString(string parentId, string name, string user, string courseId);

        [OperationContract]
        string update(parentUpdate parent);

        [OperationContract]
        string deleteString(string childId, string user);

        [OperationContract]
        string delete(parentDelete use);

        [OperationContract]
        string deleteAllString(string courseId, string user);

        [OperationContract]
        string deleteAll(parentDeleteAll use);

        //  Settings

        [OperationContract]
        parentOptions readOptions(Guid parentId, Guid user);

        [OperationContract]
        string updateOptions(Guid parentId, parentOptions options, Guid user);

        //  Only used when parent is fully deleted
        //  Cannot be called outside
        //[OperationContract]
        //void deleteOptions(Guid parentId, Guid user);
    }

    [DataContract]
    public class parentClass
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public Guid courseId { get; set; }

        [DataMember]
        public List<childClass> child { get; set; }
    }

    [DataContract]
    public class parentUpdate
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid user { get; set; }

        [DataMember]
        public Guid courseId { get; set; }
    }

    [DataContract]
    public class parentCreate
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid user { get; set; }

        [DataMember]
        public Guid courseId { get; set; }
    }

    [DataContract]
    public class parentDelete
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

    [DataContract]
    public class parentDeleteAll
    {
        [DataMember]
        public Guid courseId { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

    //  Settings
    [DataContract]
    public class parentOptions
    {
        [DataMember]
        public Guid parentId { get; set; }

        [DataMember]
        public Guid user { get; set; }

        [DataMember]
        public string parentName { get; set; }

        [DataMember]
        public DateTime releaseDate { get; set; }
    }
}
