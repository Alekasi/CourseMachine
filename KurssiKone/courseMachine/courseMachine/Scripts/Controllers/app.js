(function () {
    'use strict';

    angular.module('course', ['ngRoute'])

        //  courses configure information
    .service('configService', function ($scope, $http, $window) {
        $scope.siteRoot = "";
        $scope.user = "";
        //  info about course
        $scope.config = [];

        $window.onresize = function () {
            $scope.screenWidth = $window.innerwidth;
            console.log($scope.screenWidth);
        }
        $window.onresize();

        //  Fetch courses information
        $scope.fetchConfig = function () {
            $http.get($scope.siteRoot + '', {
                params: {
                    course: $scope.config.course,
                    user: $scope.user
                }
            }).then(function (response) {
                //  If fetch successfull
                $scope.config = response.data;
            }, function (error) {
                //  If not
                $scope.config = error.data;
                console.log($scope.config);
            });
        }

        //  End of service
    })

        //  Means for creating new parameters
    .service('parameterService', function ($scope, $http, configService, childService) {
        //  Creates new instance of parameter to db
        $scope.insertParameter = function (type) {
            $http.get($scope.siteRoot + '', {
                params : {
                    type: type,
                    creator: configService.user,
                    course: configService.config.course.name,
                    child: childService.currentChild
                }
            }).then(function (response) {
                $scope.parameterResponse = response.data;
                console.log(response.data);
            }, function (error) {
                $scope.parameterResponse = error.data;
                console.log(error);
            })
        }


    })

        //  Fetches and sets the courseTree
    .service('courseService', function ($scope, $http) {
        $scope.siteRoot = "";
        $scope.user = "";
        //  the fetched courseTree
        $scope.course = [];

        //  Fetch the courses tree
        $scope.fetchCourse = function () {
            $http.get($scope.siteRoot + '', {
                params: {
                    course: $scope.config.course,
                    user: $scope.user
                }
            }).then(function (response) {
                //  If fetch successfull
                $scope.course = response.data;
            }, function (error) {
                //  If not
                $scope.course = error.data;
                console.log($scope.course);
            });
        }
    })

        //  Fetches and sets courseChild (parameters under particular child)
    .service('childService', function ($scope, $http) {
        $scope.siteRoot = "";
        $scope.user = "";
        //  all fetched children
        $scope.childList = [];
        //  selected Child
        $scope.child = [];

        $scope.currentChild = "";

        //  Fetch child and add to list
        $scope.fetchChild = function (child) {
            $http.get($scope.siteRoot + '', {
                params: {
                    course: $scope.config.course,
                    child: child,
                    user: $scope.user
                }
            }).then(function (response) {
                //  If fetch successfull
                $scope.childList[child] = response.data;
            }, function (error) {
                //  If not
                console.log(error.data);
            })
            $scope.child = $scope.childList[child];
        }

        //  Sets the child
        //  Either by fetching or getting locally
        $scope.setChild = function (child) {
            if ($scope.childList[child] != null) {
                $scope.child = $scope.childList[child];
            } else {
                $scope.fetchChild(child);
            }
            $scope.currentChild = child;
            $scope.currentChild = child;
            console.log("Setting child " + child);
        }
    })

})();

