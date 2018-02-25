using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace courseBackGround.course
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Icourse" in both code and config file together.
    [ServiceContract]
    public interface Icourse
    {
        [OperationContract]
        int checkCourse(string course);

        [OperationContract]
        byte[] imgToByte(System.Drawing.Image img);

        [OperationContract]
        string createCourseString(string name, string user);

        [OperationContract]
        string createCourse(create use);

        [OperationContract]
        courseClass courseInfo(string course, string user);

        [OperationContract]
        List<courseClass> fetchCourses(int fetch, int jump);

        [OperationContract]
        string updateString(string id, courseUpdate course);

        [OperationContract]
        string update(Guid id, courseUpdate course);

        [OperationContract]
        string deleteString(string courseId, string user);

        [OperationContract]
        string delete(courseDelete use);
    }

    [DataContract]
    public class create
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

    [DataContract]
    public class courseClass
    {

        [DataMember]
        public Guid courseId { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Guid creator { get; set; }

        [DataMember]
        public Guid company { get; set; }  

        [DataMember]
        public DateTime created { get; set; }

        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string information { get; set; }

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public int price { get; set; }

        [DataMember]
        public string currency { get; set; }

        [DataMember]
        public int duration { get; set; }

        [DataMember]
        public string durationUnit { get; set; }
    }

    [DataContract]
    public class courseUpdate
    {
        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string information { get; set; }

        [DataMember]
        public int price { get; set; }

        [DataMember]
        public string currency { get; set; }

        [DataMember]
        public int duration { get; set; }

        [DataMember]
        public string durationUnit { get; set; }
    }

    [DataContract]
    public class courseDelete
    {
        [DataMember]
        public Guid courseId { get; set; }

        [DataMember]
        public Guid user { get; set; }
    }

}
