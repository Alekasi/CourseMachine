using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace courseBackGround.permission
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ipermission" in both code and config file together.
    // PErmission type
    //  Permissions are divided into 2 parts :
    //  1. Permission and details
    //  2. Permissions set for users

        //  This does not include users

    public class userPermissionPrototype
    {
        public Guid permissionId { get; set; }

        public Guid user { get; set; }

        //  courseId, ParentId, (childId)
        public Guid typeId { get; set; }
        
        public DateTime lisenced { get; set; }
    }

    public class permissionProtytype
    {
        public Guid permissionId { get; set; }

        public Guid courseId { get; set; }

        public string name { get; set; }

        /*
         0. CourseId
         1. ParentId
         2. ChildId
         */
        public int idType { get; set; }

        public string idList { get; set; }

        /*
         0. No permission
         1. Read
         2. Modify
        */
        public int permissionType { get; set; }

        /*
         0. Free
         1. Trial
         2. Paid
         */
        public int paymentType { get; set; }

        /*  Lisences type
         0. Unlimited
         1. Timed
         2. Valid until completition
        */
        public int lisenceType { get; set; }

        public DateTime created { get; set; }

        public Guid creator { get; set; }
        
    }

    [ServiceContract]
    public interface Ipermission
    {

        [OperationContract]
        List<permissionClass> getPermission(Guid courseId, Guid user);

        [OperationContract]
        Guid createPermission(Guid courseId, string name, int type, Guid creator, List<Guid> permissions);

        [OperationContract]
        int updatePermission(Guid permissionId, Guid user, string name, int type, List<Guid> permissions);

        [OperationContract]
        int deletePermission(Guid permissionId, Guid user);

        [OperationContract]
        string doStuff();

        //  Userstuff

        [OperationContract]
        string setUserPermission();

        [OperationContract]
        string deleteUserPermission();
    }

    //  The more exact permission description
    [DataContract]
    public class permissionClass
    {
        [DataMember]
        public Guid permissionId { get; set; }

        [DataMember]
        public Guid courseId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public List<Guid> permissions { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public DateTime created { get; set; }
    }

    //  who has the permission  (duh)
    [DataContract]
    public class userPermission
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid permissionId { get; set; }

        [DataMember]
        public Guid user { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public DateTime dateTime { get; set; }
    }
}
