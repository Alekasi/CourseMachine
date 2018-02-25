using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Data.SqlClient;

using courseMachineUi.courseReference;
using courseMachineUi.parentService;
using courseMachineUi.ChildReference;
using courseMachineUi.parameterReference;

//  cloud wcf
//using courseMachineUi.parameterCloud;
//using courseMachineUi.childCloud;
//using courseMachineUi.parentCloud;
//using courseMachineUi.courseCloud;
//using courseMachineUi.userCloud;

namespace courseMachineUi.Controllers
{
    public class childName
    {
        public string child { get; set; }
    }

    public class courseController : ApiController
    {

        [RoutePrefix("api/create")]
        public class createController : ApiController
        {
           
            [HttpGet]
            [Route("course")]
            public string courseCreate(string name, string creator)
            {
                if (name.Length <= 0 || name == null) { return "nameNull"; }
                //if (creator.Length <= 0 || creator == null) { return "creatorNull"; }
                creator = Guid.NewGuid().ToString();
                IcourseClient create = new IcourseClient();
                string response = create.createCourseString(name, creator);

                return response;
            }

            [HttpGet]
            [Route("parent")]
            public string parentCreate(string name, string course)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                //if (creator == null || creator.Length <= 0) return "creatorNull";
                if (course == null || course.Length <= 0) return "courseNull";

                string response = "";
                Guid parentGuid = new Guid();

                try
                {
                    IparentClient create = new IparentClient();
                    string parentString = create.createString(name, new Guid().ToString(), course);
                    try
                    {
                        parentGuid = new Guid(parentString);
                        response = parentGuid.ToString();
                    }
                    catch
                    {
                        response = parentString;
                    }
                }
                catch
                {
                    return "Error";
                }

                return response.ToString();
            }

            [HttpGet]
            [Route("child")]
            public string childCreate(string name, string parent)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                //if (creator == null || creator.Length <= 0) return "creatorNull";
                if (parent == null || parent.Length <= 0) return "parentNull";

                string response = "controllerError";
                Guid childGuid = Guid.NewGuid();
                try
                {
                    IchildClient create = new IchildClient();
                    response = create.createString(parent, name, Guid.NewGuid().ToString());
                    try
                    {
                        response = new Guid(response).ToString();
                    }
                    catch(Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                catch(Exception ex)
                {
                    return "ErrorUI : " + ex.ToString(); ;
                }

                return response;
            }

            [HttpGet]
            [Route("parameter")]
            public string parameterCreate(string type, string creator,string child)
            {
                creator = Guid.NewGuid().ToString();
                if (creator == null || creator.Length <= 0) return "creatorNull";
                if (child == null || child.Length <= 0) return "childNull";
                string response = "";

                IparameterClient para = new IparameterClient();

                try
                {
                    response = para.createString(type, child, creator);
                    //try
                    //{
                    //    response = new Guid(response).ToString();
                    //}
                    //catch
                    //{
                    //    response = "Error";
                    //}
                }catch(Exception ex)
                {
                    response = ex.ToString();
                }

                return response;
            }
        }

        [RoutePrefix("api/update")]
        public class updateController : ApiController
        {

            [HttpGet]
            [Route("course")]
            public string courseUpdate(courseClass list)
            {
                courseUpdate update = new courseUpdate();
                IcourseClient client = new IcourseClient();
                string response = "Error";

                    try
                    {
                        update.status = list.status;
                        update.information = list.information;
                        update.price = list.price;
                        update.currency = list.currency;
                        update.duration = list.duration;
                        update.durationUnit = list.durationUnit;

                        response = client.updateString(list.courseId.ToString(), update);
                    }
                    catch
                    {
                        //  Error
                    }

                return response;
            }

            [HttpGet]
            [Route("parent")]
            public string parentUpdate()
            {
                return "";
            }

            [HttpGet]
            [Route("child")]
            public string childUpdate()
            {
                return "";
            }

            [HttpGet]
            [Route("parameter")]
            public string parameterUpdate(string childId, string parameterId, string creator, string type, string value, string order, string status, string additional_1, string additional_2, string additional_3, string additional_4)
            {
                creator = new Guid().ToString();

                string response = "";
                IparameterClient para = new IparameterClient();
                try
                {
                    response = para.updateString(childId,  parameterId,  creator,  type,  value,  order, status);
                }
                catch
                {
                    response = "Error";
                }

                return response;
            }

            [HttpPost]
            [Route("post")]
            public string updateParameters(parameterReference.parameterClass para)
            {
                string response = "";   
                try
                {
                    IparameterClient client = new IparameterClient();
                    response = client.updateString(para.childId.ToString(), para.parameterId.ToString(), para.creator.ToString(), para.type, para.value, para.order, para.status);
                }
                catch(Exception ex)
                {
                    response = "Error : " + ex.ToString();
                }

                return response;
            }   
            //[HttpGet]
            //[Route("parameters")]
            //public string parametersUpdate(string childId, List<parameterReference.parameterClass> parameters)
            //{
            //    string response = "";
            //    IparameterClient para = new IparameterClient();
            //    try
            //    {
            //        response = para.update(parameters);
            //    }
            //    catch
            //    {
            //        response = "Error";
            //    }
            //    return response;
            //}
        }
        
        [RoutePrefix("api/read")]
        public class readController : ApiController
        {
            //  Fetch the whole course
            [HttpGet]
            [Route("courses")]
            public IEnumerable<courseClass> fetchCourses()
            {
                List<courseClass> response = new List<courseClass>();
                IcourseClient fetch = new IcourseClient();
                try
                {
                    response = fetch.fetchCourses(0, 0).ToList();
                }
                catch
                {

                }

                return response;
            }

            [HttpGet]
            [Route("course")]
            public IEnumerable<courseClass> courseInfo(string courseId)
            {
                IcourseClient client = new IcourseClient();
                courseClass cou = client.courseInfo(courseId, new Guid().ToString()); ;
                List<courseClass> response = new List<courseClass>();
                response.Add(cou);
                return response;
            }

            [HttpGet]
            [Route("parent")]
            public IEnumerable<parentClass> fetchParent(string courseId)
            {
                List<parentClass> response = new List<parentClass>();
                IparentClient read = new IparentClient();
                try
                {
                    response = read.readString(courseId).ToList();
                }
                catch
                {

                }
                return response;
            }

            [HttpGet]
            [Route("child")]
            public IEnumerable<ChildReference.childClass> fetchChild(string course, string parent)
            {
                List<ChildReference.childClass> response = new List<ChildReference.childClass>();
                IchildClient read = new IchildClient();
                try
                {
                    response = read.readString(parent).ToList();
                }
                catch
                {

                }

                return response;
            }

            [HttpGet]
            [Route("parameter")]
            public IEnumerable<parameterReference.parameterClass> parameters(string child)
            {
                IparameterClient read = new IparameterClient();
                List<parameterReference.parameterClass> response = new List<parameterReference.parameterClass>();
                try
                {
                    response = read.readString(child).ToList();
                }
                catch(Exception ex)
                {
                    parameterReference.parameterClass para = new parameterReference.parameterClass();
                    para.value = ex.ToString();
                    response.Add(para);
                }
                return response;
            }
        }

        [RoutePrefix("api/delete")]
        public class deleteController : ApiController
        {
            [HttpGet]
            [Route("course")]
            public string course(string courseId)
            {
                string response = "Success";
                IcourseClient use = new IcourseClient();
                try
                {
                    response = use.deleteString(new Guid(courseId).ToString(), Guid.NewGuid().ToString());
                }
                catch
                {
                    response = "Error";
                }
                return response;
            }

            [HttpGet]
            [Route("parent")]
            public string parent(string parentId)
            {
                string response = "Success";
                try
                {
                    IparentClient use = new IparentClient();
                    response = use.deleteString(new Guid(parentId).ToString(), Guid.NewGuid().ToString());
                }
                catch(Exception ex)
                {
                    response = ex.ToString();
                }
                return response;
            }

            [HttpGet]
            [Route("child")]
            public string child(string childId)
            {
                string response = "Success";
                try
                {
                    IchildClient use = new IchildClient();
                    //  Script for deleting child
                    response = use.deleteString(childId, new Guid().ToString());
                }
                catch(Exception ex)
                {
                    response = ex.ToString();
                }
                return response;
            }

            [HttpGet]
            [Route("parameter")]
            public string parameter(string parameterId)
            {
                string response = "Success";
                try
                {
                    IparameterClient para = new IparameterClient();
                    response = para.deleteString(Guid.NewGuid().ToString() ,parameterId);
                }
                catch
                {
                    response = "Error";
                }
                return response;
            }

        }

        [RoutePrefix("api/user")]
        public class userController
        {

        }

        //  Remember : Apicontrollers
        [RoutePrefix("api/permission")]
        public class permissionController
        {
            //[HttpPost]
            //[Route("get")]
            //public IEnumerable<> getPermissions()
            //{
            //    return new IEnumerable<>();
            //}

            [HttpGet]
            [Route("createPermission")]
            public string createPermission(string courseId, string creator, string name, IEnumerable<permissionReference.permissionType> permissions)
            {
                string response = "Success";
                try
                {
                    permissionReference.IpermissionClient perm = new permissionReference.IpermissionClient();
                    //response = perm.createPermission(new Guid(courseId), new Guid(creator), name, new List<permissionReference.permissionType>(permissions));
                }
                catch(Exception ex)
                {
                    response = ex.ToString();
                }
                return response;
            }
        }

        [RoutePrefix("api/test")]
        public class testController : ApiController
        {
            [HttpGet]
            [Route("string")]
            public string testString()
            {
                return "TestString";
            }

            [HttpGet]
            [Route("childstring")]
            public string childCreate(string name, string parent)
            {
                if (name == null || name.Length <= 0) return "nameNull";
                //if (creator == null || creator.Length <= 0) return "creatorNull";
                if (parent == null || parent.Length <= 0) return "parentNull";

                string response = "controllerError";
                Guid childGuid = Guid.NewGuid();
                try
                {
                    IchildClient create = new IchildClient();
                    response = create.createString(parent, name, Guid.NewGuid().ToString());
                    try
                    {
                        response = new Guid(response).ToString();
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                catch (Exception ex)
                {
                    return "ErrorUI : " + ex.ToString(); ;
                }

                return response;
            }

            [HttpGet]
            [Route("fileUpload")]
            public string fileUpload(string user, HttpPostedFileBase[] files)
            {
                string response = "";

                try
                {
                    if(files.Count() <= 0)
                    {
                        response = "FilesNull";
                    }
                }catch(Exception ex)
                {
                    response = ex.ToString();
                }

                return response;
            }
        }


        //  Post Calls


        [HttpPost]
        public string testPost(string test)
        {
            return "Success : " + test;
        }
    }

    public class settingsController : ApiController {
        [RoutePrefix("settings/read")]
        public class read : ApiController
        {
            [HttpGet]
            [Route("child")]
            public childOptions readChildOptions(string childId)
            {
                IchildClient child = new IchildClient();
                childOptions response = new childOptions();
                response = child.readOptions(new Guid(childId), Guid.NewGuid());

                return response;
            }
        }

        [RoutePrefix("settings/update")]
        public class update : ApiController
        {
            [HttpGet]
            [Route("child")]
            public string updateChildOptions(string child, string user, string releaseDate, string releaseDates)
            {
                string response = "";

                IchildClient client = new IchildClient();
                childOptions options = new childOptions();

                options.childId = new Guid(child);
                options.user = new Guid(user);
                options.releaseDate = DateTime.Parse(releaseDate);
                options.releaseDates = Convert.ToInt32(releaseDates.Length <= 0 || releaseDates == null ? "0" : releaseDates);

                //response = client.updateOptions(options);

                return response;
            }
        }
    }
}
