(function () {
    'use strict';

    angular
        .module('course')
        .controller('configController', configController);

    function configController($scope, $http, $window, $timeout) {

        $scope.siteRoot = "http://localhost:63103/";
        //$scope.siteRoot = "http://coursecloudmachine.azurewebsites.net/";
        $scope.parents = [];
        $scope.parameters = [];
        $scope.course = [];
        $scope.courseSettings = [];

        $scope.courseId = $window.location.search.slice(10);

        $scope.childId = "";
        $scope.treeTableAlertType = "info";
        $scope.treeTableNotification = "false";
        $scope.treeTableNotificationMessage = "";

        $scope.parameterAlertType = "info";
        $scope.parameterNotification = "false";
        $scope.parameterNotificationMessage = "";

        $scope.courseOptions = true;
        $scope.parentOptions = false;
        $scope.childOptions = false;
        $scope.showParameters = false;

        $scope.ismodified = false;

        // 

        $scope.modify = function () {
            if ($scope.ismodified != false) {
                $scope.ismodified = true;
            }
        }

        //  Permissions

        $scope.permissions = [];

        $scope.permission = {
            name: "",
            canEdit: false,
            indexName: "indexName",
            displayName: "displayName"
        }

        $scope.getpermissions = function () {
            $http.get($scope.siteroot + '',
            {
                params: {
                    course: $scope.courseId
                }
            }).then(function (response) {
                $scope.permissions = response.data;
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        //  Giving permission for another user
        $scope.setPermissions = function(email, permissionType, user) {
            if (!email.contains("@") && email.length <= 0) {
                //  Do stuff
                return;
            }
            permissionType = permissionType == null || permissionType.length <= 0 ? 'read' : permissionType;
            if (user == null || use.length <= 0) {
                //  Do stuff
                return;
            }

            $scope.get($scope.siteroot + '',
            {
                params: {
                    
                }
            }).then(function(response) {
                console.log(response.data);
            }), function(error) {
                console.log(error);
            }
        }

        $scope.newPermission = function() {
            if ($scope.permission.name == null || $scope.permission.name.length <= 0) {
                return;
            }

            $http.get($scope.siteroor + '',
            {
                params: {
                    
                }
            }).then(function (response) {
                //  Do something if succesfull
                $scope.getpermissions();
                console.log(response.data);
            }), function(error) {
                console.log(error);
            }
        }

        $scope.deletePermission = function(permissionId) {
            
        }

        //  Fethcing

        $scope.fetchTree = function () {
            
            $http.get($scope.siteRoot + 'api/read/parent', {
                params: {
                    courseId: $scope.courseId
                }
            }).then(function (response) {
                $scope.parents = response.data;
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
            console.log($scope.courseId);
        }

        $scope.displayChild = function (childId) {
            if (childId.length <= 0) {
                return;
            }
            console.log(childId);
            $scope.childId = childId;
            $http.get($scope.siteRoot + 'api/read/parameter', {
                params: {
                    child: childId
                }
            }).then(function (response) {
                $scope.parameters = response.data;
                $scope.modify(false);
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }

            //var req = {
            //    child: childId
            //}
            //$http.post(
            //    '/api/read/parameter',
            //    JSON.stringify(req),
            //    {
            //        headers: {
            //            'Content-Type': 'application/json'
            //        }
            //    }
            //).then(function (response) {
            //    $scope.parameters = response.data;
            //    $scope.modify(false);
            //    console.log(response);
            //})

        }

        $scope.fetchCourseInfo = function () {
            $http.get($scope.siteRoot + 'api/read/course', {
                params: {
                    courseId: $scope.courseId
                }
            }).then(function (response) {
                $scope.course = response.data;
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        //  Creating

        $scope.createParent = function (parentName) {
            if (parentName == null) {
                console.log("parentNameNull");
                return;
            }
            if (parentName.length <= 0) {
                console.log("parentNameNull");
                return;
            }
            console.log("Trying to create " + parentName);
            $http.get($scope.siteRoot + 'api/create/parent', {
                params: {
                    name: parentName,
                    course : $scope.courseId
                }
            }).then(function (response) {
                console.log(response);
                $scope.fetchTree();
            }), function (error) {
                console.log(error);
            }
        }

        $scope.createChild = function (childName, parentId) {
            if (childName == null) {
                console.log("ChildNameNull");
                return;
            }
            if (childName.length <= 0) {
                console.log("ChildNameNull");
                return;
            }

            console.log("Trying to create new child : " + childName + " " + parentId);
            $http.get($scope.siteRoot + 'api/create/child', {
                params: {
                    name: childName,
                    parent: parentId
                }
            }).then(function (response) {
                console.log(response);
                $scope.fetchTree();
                $scope.displayChild(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.createParameter = function (type) {
            var child = {
                parameterId: $scope.parameters.length,
                creator: "",
                type: type,
                value: "",
                childId: $scope.childId,
                order: $scope.parameters.length,
                status: "",
                additional_1: "",
                additional_2: "",
                additional_3: "",
                additional_4: ""
            }
            $scope.parameters.push(child);

            //$http.get($scope.siteRoot + 'api/create/parameter', {
            //    params: {
            //        type: type,
            //        creator: "",
            //        child: $scope.childId
            //    }
            //}).then(function (response) {
            //    console.log(response.data);
            //    $scope.saveParameter();
            //    $scope.displayChild($scope.childId);
            //}), function (error) {
            //    console.log(error);
            //}
        }

        //  Saving

        $scope.saveCourse = function () {
            $http.get($scope.siteroot + 'api/update/course', {
                params: {
                    list : $scope.course
                }
            }).then(function(response){
                $scope.course = response.data;
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.saveParameter = function () {
            for (var i = 0; i < $scope.parameters.length; i++) {
                if($scope.parameters[i].type != 'img'){
                    $http.get($scope.siteRoot + 'api/update/parameter', {
                        params: {
                            childId: $scope.parameters[i].childId,
                            parameterId: $scope.parameters[i].parameterId,
                            creator: $scope.parameters[i].creator,
                            type: $scope.parameters[i].type,
                            value: $scope.parameters[i].value,
                            order: i,
                            status: $scope.parameters[i].status,
                            additional_1: "",
                            additional_2: "",
                            additional_3: "",
                            additional_4: ""
                        }
                    }).then(function (response) {
                        $scope.modify(false);
                        console.log(response.data);
                    }), function (error) {
                        console.log(error);
                    }
                } else {
                    var req = {
                        childId: $scope.parameters[i].childId,
                        parameterId: $scope.parameters[i].parameterId,
                        creator: $scope.parameters[i].creator,
                        type: $scope.parameters[i].type,
                        value: $scope.parameters[i].value,
                        order: i,
                        status: $scope.parameters[i].status,
                        additional_1: "",
                        additional_2: "",
                        additional_3: "",
                        additional_4: ""
                    }
                        $http.post(
                            '/api/update/post',
                            JSON.stringify(req),
                            {
                                headers: {
                                    'Content-Type': 'application/json'
                                }
                            }
                        ).then(function (response) {
                            console.log(response);
                        })
                }
            }
        }

        //  Deleting

        $scope.deleteParent = function (parentId) {
            $http.get($scope.siteRoot + 'api/delete/parent', {
                params: {
                    parentId: parentId
                }
            }).then(function (response) {
                console.log(response);
                $scope.fetchTree();
                $scope.displayChild($scope.childId);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.deleteChild = function (childId) {
            $http.get($scope.siteRoot + 'api/delete/child', {
                params: {
                    childId: childId
                }
            }).then(function (response) {
                console.log(response);
                $scope.fetchTree();
                $scope.displayChild($scope.childId);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.deleteParameter = function (pararameterId) {
            console.log("Deleting parameter " + pararameterId);
            for (var i = 0; i < $scope.parameters.length; i++) {
                if ($scope.parameters[i].parameterId == pararameterId) {
                    $scope.parameters[i].status = 'delete';
                    break;
                }
            }
            //$http.get($scope.siteRoot + 'api/delete/parameter', {
            //    params: {
            //        parameterId : pararameterId
            //    }
            //}).then(function (response) {
            //    console.log(response);
            //    $scope.displayChild($scope.childId);
            //}), function (error) {
            //    console.log(error);
            //}
        }

        //  Notifications

        $scope.treeTableNote = function (content, alert) {
            content = content.charAt(0).toUpperCase() + content(1);
            $scope.treeTableNotificationMessage = content;
            $scope.treeTableAlertType = alert == null ? "warning" : alert;
            $scope.treeTableNotification = true;

            $timeout(function () {
                $scope.treeTableNotification = false;
            }, 8000);
        }

        $scope.parameterNote = function (content, alert) {
            $scope.parameterNotificationMessage = content;
            $scope.parameterAlertType = alert == null ? "warning" : alert;
            $scope.parameterNotification = true;

            $timeout(function () {
                $scope.parameterNotification = false;
            }, 8000);
        }


        //  Users

        $scope.users = [];

        $scope.fetchUsers = function () {
            $http.get($scope.siteroot + '',
            {
                params: {
                    courseId: $scope.courseId
                }
            }).then(function (response) {
                //  Do something when success
                $scope.users = response.data;
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.addUser = function() {
            
        }

        $scope.deleteUser = function(userId) {
            if (userId == null || userId.length <= 0) {
                return;
            }
            $http.get($scope.siteroot + '',
            {
                params: {
                    user: userId,
                    courseId: $scope.courseId
                }
            }).then(function (response) {
                //  Show output from delete
                console.log(response.data);
            }), function(error) {
                console.log(error);
            }

        }

        //  Course

        $scope.courseSettings = [];

        $scope.getCourseSettings = function() {
            $http.get($scope.siteroot + '',
            {
                params: {
                    course: $scope.courseId
                }
            }).then(function(response) {
                $scope.courseSettings = response.data;
                console.log(response);
            }), function(error) {
                console.log(error);
            }
        }

        $scope.saveCourseSettings = function() {
            $http.get($scope.siteroot + '',
            {
                params: {
                    
                }
            }).then(function (response) {
                //  Do something with this
                console.log(response.data);
            }),function(error) {
                console.log(error);
            }
        }

        //  Parent

        /*
            $scope.parentOptions = [
            parentName,
            ReleaseDate
            ]
        */
        $scope.getParentSettings = function(parent) {
            if (parent == null || parent.length <= 0) {
                return;
            }
            $http.get($scope.siteroot + '',
            {
                params: {
                    parentId: parent
                }
            }).then(function (response) {
                for (var i = 0; i < $scope.parent.length; i++) {
                    if ($scope.parents[i].parentId == parent) {
                        $scope.parents[i].settings = response.data;
                    }
                }
                console.log(response.data);
            }), function(error) {
                console.log(error);
            }
        }

        $scope.saveParentSettings = function(parent) {
            for (var i = 0; i < $scope.parent.length; i++) {
                if ($scope.parent[i].parentId == parent) {
                    $http.get($scope.siteroot + '',
                    {
                        params: {
                            //  Place settings here
                        }
                    }).then(function(response) {
                        console.log(response.data);
                    }), function(error) {
                        console.log(error);
                    }
                    break;
                }
            }
        }

        //  Child
        $scope.currentChildSettings = [];

        //  This is propably not going to be used
        $scope.getChildSettings = function (child) {
            if (child == null || child.length <= 0) {
                return;
            }
            $http.get($scope.siteroot + 'settings/read/child',
            {
                params: {
                    childId: child
                }
            }).then(function (response) {

                console.log(response.data);
            }), function (error) {
                console.log(error);
            }

            //for (var i = 0; i < $scope.parent.child.length; i++) {
            //    $http.get($scope.siteroot + 'settings/read/child',
            //{
            //    params: {
            //        childId: child
            //    }
            //})
            //}
        }

        $scope.displayChildSettings = function (child) {

        }

        //  Additional

        $scope.displaySettings = function(display, id) {
            switch(display) {
                case "course":
                    $scope.courseOptions = true;
                    $scope.parentOptions = false;
                    $scope.childOptions = false;
                    $scope.showParameters = false;
                    $scope.getCourseSettings();
                    break;
                case "parent":
                    $scope.courseOptions = false;
                    $scope.parentOptions = true;
                    $scope.childOptions = false;
                    $scope.showParameters = false;
                    $scope.getParentSettings(id);
                    break;
                case "child":
                    $scope.courseOptions = false;
                    $scope.parentOptions = false;
                    $scope.childOptions = true;
                    $scope.showParameters = false;
                    //$scope.getChildSettings(id);

                    break;
                case "parameter":
                    $scope.courseOptions = false;
                    $scope.parentOptions = false;
                    $scope.childOptions = false;
                    $scope.showParameters = true;
                    $scope.displayChild(id);
                    break;
                default:
                    $scope.courseOptions = true;
                    $scope.parentOptions = false;
                    $scope.childOptions = false;
                    $scope.showParameters = false;
                    break;
            }
            console.log(display + ' set to True');
        }

        // AutoRun

        $scope.fetchTree();

        //$scope.displaySettings("course", null);

        //$scope.fetchCourseInfo();

        // Testing

        $scope.uploadFile = function () {
            console.log("Attempting to establish call for : " + document.getElementsByClassName('imgFile')[0].files[0]);
            $http.get($scope.siteRoot + 'api/test/fileUpload', {
                params: {
                    user: "tere",
                    file: document.getElementsByClassName('imgFile')[0].files
                }
            }).then(function (response) {
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.imgChange = function () {
            console.log("ImageChanged");
        }

        //var req = {
        //    'test' : 'testString'
        //}
        //$scope.test = function () {
        //    $http.post(
        //        '/',
        //        JSON.stringify(req),
        //        {
        //            headers: {
        //                'Content-Type': 'application/json'
        //            }
        //        }
        //    ).then(function (response) {
        //        console.log(response);
        //    })
        //}

        //$scope.test();
    }
})();
 