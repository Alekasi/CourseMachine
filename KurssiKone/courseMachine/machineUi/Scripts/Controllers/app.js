(function () {
    'use strict';

    angular.module('course', ['ngRoute'])

    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: "Index",
                controller: ""
            }).when('/about', {
                templateUrl: "Home/about",
                controller: ""
            }).when('/contact', {
                templateUrl: "Home/contact"
            }).when('/hub', {
                templateUrl: "Home/Hub",
                controller: "hubController"
            }).when('/config', {
                templateUrl: "courseConfig",
                controller: ""
            }).when('/view', {
                templateUrl: "courseViewer",
                controller: ""
            }).otherwise({
                redirectTo : "/"
            })

        $locationProvider.html5Mode(true);
    })

        //  courses configure information
    .service('configService', function ($http, $window, $routeParams) {
        this.siteRoot = "http://coursecloudmachine.azurewebsites.net/";
        this.user = "";
        this.courseId = $routeParams.course;
        //  info about course
        this.config = [];

        //  Fetch courses information
        this.fetchConfig = function () {
            $http.get(this.siteRoot + 'api/read/course', {
                params: {
                    course: this.courseId,
                    user: this.user
                }
            }).then(function (response) {
                //  If fetch successfull
                this.config = response.data;
                console.log(this.config);
            }, function (error) {
                //  If not
                this.config = error.data;
                console.log(this.config);
            });
        }

        //  End of service
    })

        //  Means for creating new parameters
    .service('parameterService', function ($http, configService, childService) {
        //  Creates new instance of parameter to db
        this.insertParameter = function (type) {
            $http.get(this.siteRoot + '', {
                params : {
                    type: type,
                    creator: configService.user,
                    course: configService.config.course.name,
                    child: childService.currentChild
                }
            }).then(function (response) {
                this.parameterResponse = response.data;
                console.log(response.data);
            }, function (error) {
                this.parameterResponse = error.data;
                console.log(error);
            })
        }


    })

        //  Fetches and sets the courseTree
    .service('courseService', function ($http) {
        this.siteRoot = "";
        this.user = "";
        //  the fetched courseTree
        this.course = [];

        //  Fetch the courses tree
        this.fetchCourse = function () {
            $http.get(this.siteRoot + '', {
                params: {
                    course: this.config.course,
                    user: this.user
                }
            }).then(function (response) {
                //  If fetch successfull
                this.course = response.data;
            }, function (error) {
                //  If not
                this.course = error.data;
                console.log(this.course);
            });
        }
    })

        //  Fetches and sets courseChild (parameters under particular child)
    .service('childService', function ($http) {
        this.siteRoot = "";
        this.user = "";
        //  all fetched children
        this.childList = [];
        //  selected Child
        this.child = [];

        this.currentChild = "";

        //  Fetch child and add to list
        this.fetchChild = function (child) {
            $http.get(this.siteRoot + '', {
                params: {
                    course: this.config.course,
                    child: child,
                    user: this.user
                }
            }).then(function (response) {
                //  If fetch successfull
                this.childList[child] = response.data;
            }, function (error) {
                //  If not
                console.log(error.data);
            })
            this.child = this.childList[child];
        }

        //  Sets the child
        //  Either by fetching or getting locally
        this.setChild = function (child) {
            if (this.childList[child] != null) {
                this.child = this.childList[child];
            } else {
                this.fetchChild(child);
            }
            this.currentChild = child;
            this.currentChild = child;
            console.log("Setting child " + child);
        }
    })

})();

