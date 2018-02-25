(function () {
    'use strict';

    angular
        .module('course')
        .controller('hubController', courseController)

    function courseController($scope, $http, $window) {

        $scope.siteRoot = "http://localhost:63103/";
        //$scope.siteRoot = "http://coursecloud.azurewebsites.net/";

        $scope.courses = [];

        $scope.setPage = function () {
            $scope.page.goto > $scope.page.total ? $scope.page.total : $scope.page.goto;
            $scope.hub = [];
            for (var i = 0; i < $scope.page.perPage; i++) {
                $scope.hub.push($courses[$scope.page.perPage * $scope.page.goto + 1]);
            }
        }

        $scope.fetchCourses = function () {
            $http.get($scope.siteRoot + 'api/read/courses', {
                params: {
                    //  No params
                }
            }).then(function (response) {
                $scope.courses = response.data;
                console.log("success");
                console.log(response.data);
            }), function (error) {
                console.log(error);
            }
        }

        $scope.displayDetails = function (courseID) {
            console.log(courseID);
            $window.location.href = $scope.siteRoot + "Config/course/courseview?courseId=" + courseID;
        }

        $scope.createCourse = function (name) {
            if (name == null || name.length <= 0) {
                console.log("NameIsNull");
                return;
                // Display error
            }
            console.log("Attempting to create Course");
            $http.get($scope.siteRoot + 'api/create/course', {
                params: {
                    name: name,
                    creator : ""
                }
            }).then(function (response) {
                console.log(response.data);
                $window.location.href = $scope.siteRoot + "Config/course/courseview?courseId=" + response.data;
            }), function (error) {
                console.log(error);
            }
        }

        //  AutoFetches
        $scope.fetchCourses();

    }
})();
