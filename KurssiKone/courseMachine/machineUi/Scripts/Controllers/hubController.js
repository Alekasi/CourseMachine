(function () {
    'use strict';

    angular
        .module('course')
        .controller('hubController', courseController)

    function courseController($scope, $http, $window, configService) {
        $scope.page = {
            current: 0,
            total: 1,
            perPage: 20,
            goto: 0
        }
        $scope.showLabel = "false";

        $scope.createCourse = function () {
            var name = $scope.courseName;
            if (name == null || name.length < 5) {
                return;
            }
            console.log(configService.siteRoot);
            $http.get(configService.siteRoot + 'api/create/course', {
                params: {
                    name: name
                }
            }).then(function (response) {
                console.log(response.data);
                $window.location.href = configService.siteRoot + 'Home/courseConfig?course=' + response.data;
            }, function (error) {
                console.log(error.data);
                //  Show error message
            })
        }

        $scope.checkCourseExists = function () {
            var name = $scope.courseName;
            if (name == null || name.length < 5) {
                return;
            }

            $http.get(configService.siteRoot + 'api/check/CourseExists', {
                params:{
                    course: name
                }
            }).then(function (response) {
                console.log(response);
                switch (response.data) {
                    // 0 dont exist
                    // 1 allready exists
                    // 2 sql error
                    // 3 no name
                    case 0:
                        $scope.msgColor = "green";
                        $scope.message = "CourseName is free";
                        break;
                    case 1:
                        $scope.msgColor = "red";
                        $scope.message = "CourseName is allready taken";
                        break;
                    case 2:
                        $scope.msgColor = "yellow";
                        $scope.message = "sqlError";
                        break;
                    case 3:
                        $scope.msgColor = "red";
                        $scope.message = "courseName null";
                        break;
                    default:
                        $scope.msgColor = "yellow";
                        $scope.message = "error";
                }
            }, function (error) {
                console.log(error);
            })
        }

        $scope.setPage = function () {
            $scope.page.goto > $scope.page.total ? $scope.page.total : $scope.page.goto;
            $scope.hub = [];
            for (var i = 0; i < $scope.page.perPage; i++) {
                $scope.hub.push($courses[$scope.page.perPage * $scope.page.goto + 1]);
            }
        }

        $scope.fetchCourses = function () {
            $http.get(siteRoot + '/api/hub/fetchHub', {
                params: {
                    "amount": 25
                }
            }).then(function (response) {
                $scope.response = response.data;
                console.log("success");
            }), function (response) {
                console.log(response);
            }
        }

        $scope.displayDetails = function (courseID) {

        }

        $scope.hubSelectOptions = [
            { value: '1', text: "option_1" },
            { value: '2', text: "option_2" },
            { value: '3', text: "option_3" },
            { value: '4', text: "option_4" },
        ]

        $scope.hubFilterHidden = false;
        $scope.hubAdvancedHidden = function () {
            if ($scope.hubFilterHidden == true) {
                $scope.hubFilterHidden = false;
            } else {
                $scope.hubFilterHidden = true;
            }
        }

        //  TestClient
        $scope.courses = [];
        $scope.hub = [];

        for (var i = 0; i < 15; i++) {
            $scope.courses.push({
                courseId: "courseId",
                name: "courseName" + i,
                creator: "creator",
                company: "company" + i,
                created: Date.now(),
                status: "production",
                information: "Have you ever just wanted to iterate some 12ish boxes with javascript?",
                img: "",
                price: "45",
                currency: "€",
                duration: "",
                durationUnit: ""
            });
        }

    }
})();
