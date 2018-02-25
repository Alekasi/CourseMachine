(function () {
    'use strict';

    angular
        .module('course')
        .controller('viewController', viewController);

    function viewController($scope, $http, childService, configService) {

        $scope.parameter = [];

        $scope.refresh = function () {
            $scope.parameters = childService.child;
            console.log("Updated");
            console.log($scope.child);
        }

        $scope.addParameter = function (type) {
            var parameter = {
                parameterId: "",
                creator: "",
                type: type,
                value: "",
                childId: childService.currentChild,
                order: $scope.parameters.length,
                image: {
                    imgId: "",
                    type: "",
                    name: "",
                    created: ""
                },
                video: {
                    videoId: "",
                    type: "",
                    name: "",
                    created: ""
                }
            }
            //  Save it temporary to local scope
            $scope.parameters.push(parameter);
            console.log($scope.parameters.length);

            $http.get(configService.siteRoot + 'api/create/parameter', {
                params: {
                    "type": type,
                    "creator": configService.user + 'deleteThis',// Delete That
                    "course": configService.courseId + '1',
                    "child": childService.currentChild + 'deleteThis' // Also that
                }
            }).then(function (response) {z<
                //  If succesfull
                console.log(response.data);
                parameter.parameterId = response.parameterId;
            }, function (error) {
                //  If not
                console.log(error);
                //  Try again(do this without endless loop)
            })
        }

        $http.get(configService.siteRoot + 'api/config/login', {
            params: {

            }
        }).then(function (response) {
            console.log(response.data);
        }, function (error) {
            console.log(error);
        })

        //  Do all sets for controller
        $scope.refresh();

        //  Create dummyParameters
        $scope.parameters = [];
        $scope.dummyParameters = function () {
            var header = {
                parameterId: "",
                creator: "",
                type: "header",
                value: "MyHeader",
                childId: "",
                order: 0,
                image: {
                    imgId: "",
                    type: "",
                    name: "",
                    created: ""
                },
                video: {
                    videoId: "",
                    type: "",
                    name: "",
                    created: ""
                }
            }
            $scope.parameters.push(header);

            var textArea = {
                parameterId: "",
                creator: "",
                type: "textarea",
                value: "some stuff for the textArea",
                childId: "",
                order: 0,
                image: {
                    imgId: "",
                    type: "",
                    name: "",
                    created: ""
                },
                video: {
                    videoId: "",
                    type: "",
                    name: "",
                    created: ""
                }
            }
            $scope.parameters.push(textArea);

            var img = {
                parameterId: "",
                creator: "",
                type: "img",
                value: "tere.jpg",
                childId: "",
                order: 0,
                image: {
                    imgId: "",
                    type: "",
                    name: "",
                    created: ""
                },
                video: {
                    videoId: "",
                    type: "",
                    name: "",
                    created: ""
                }
            }
            $scope.parameters.push(img);

            var video = {
                parameterId: "",
                creator: "",
                type: "video",
                value: "video.mp4",
                childId: "",
                order: 0,
                image: {
                    imgId: "",
                    type: "",
                    name: "",
                    created: ""
                },
                video: {
                    videoId: "",
                    type: "",
                    name: "",
                    created: ""
                }
            }
            $scope.parameters.push(video);
            console.log("Created dummyParameters!");
            console.log($scope.parameters);
        }
        $scope.dummyParameters();

        $scope.listParameters = [];

        $scope.dummyList = function () {
            var iteration = 0;
            for (var i = 0; i < 5; i++) {
                var para = {
                    name: "parameter" + i,
                    type: "textarea",
                    img: "tere.png"
                }
                $scope.listParameters[iteration++] = para;
            }
        }
        $scope.dummyList();
    }
})();
