(function () {
    'use strict';

    angular
        .module('courseApp')
        .controller('controller', controller);

    function controller($scope, $http, $location) {
        var siteRoot = "";

        $scope.createCourse = function () {
            $http.get(siteRoot + "/api/course/createCourse", {
                params: {
                    "courseName": "",
                    "creator": ""
                }
            }).then(function (response) {
                $scope.response = response.data;
                console.log("success");
            }), function (response) {
                console.log(response);
            }
        }

        //  Create parent for course
        $scope.createParent = function () {
            $http.get(siteRoot + "/api/course/createParent", {
                params: {
                    "course": "",
                    "parentName": "",
                    "creator" : ""
                }
            }).then(function () {

            }), function () {

            }
        }

        //  Create child for courseParent
        $scope.createChild = function () {
            $http.get(siteRoot + "/api/course/createChild", {
                params: {
                    "course": "",
                    "parent": "",
                    "childName": "",
                    "creator": ""
                }
            })
        }

        //  Update Course 
        $scope.updateCourse = function () {
            $http.get(siteRoot + "/api/course/updateCourse", {
                params: {
                    //  Create parameters
                    "course": "",
                    "user": ""
                }
            })
        }

        //  Update course Parent 
        $scope.updateParent = function () {
            $http.get(siteRoot + "/api/course/updateParerent", {
                params: {
                    //  Create parameters
                    "course": "",
                    "parent": "",
                    "user": ""
                }
            })
        }
    }
})();
