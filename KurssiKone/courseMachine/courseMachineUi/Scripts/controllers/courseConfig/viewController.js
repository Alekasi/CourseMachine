(function () {
    'use strict';

    angular
        .module('course')
        .controller('viewController', viewController);

    function viewController($scope, childService) {

        $scope.refresh = function () {
            $scope.parameter = childService.child;
            console.log("Updated");
            console.log($scope.child);
        }
        $scope.siteRoot = "";

        $scope.addParameter = function (type) {
            var parameter = {
                courseId: configService.config.name,
                childId: childService.CurrentChild,
                parameterId: "",
                type: type,
                value: ""
            }
            //  Save it temporary to local scope
            $scope.child.push(parameter);

            $http.get($scope.siteRoot + '', {
                params: {
                    //  Parameters to create new parameter
                }
            }.then(function (response) {
                //  If succesfull
                console.log(response);
                parameter.parameterId = response.parameterId;
                childService.childList[$scope.parameter.child].push(parameter);
            }, function (error) {
                //  If not
                console.log(error);
                //  Try again(do this without endless loop)
            }))

        }

        //  Do all sets for controller
        $scope.refresh();

        //  Create dummyParameters
        $scope.parameters = [];
        $scope.dummyParameters = function () {
            var i = 0;
            var header = {
                type: "header",
                display: "Header",
                img: "path/here"
            }
            $scope.parameters[i] = header;

            var textArea = {
                type: "textarea",
                display: "Textarea",
                img: ""
            }
            $scope.parameters[i++] = textArea;

            var img = {
                type: "img",
                display: "Image",
                img: ""
            }
            $scope.parameters[i++] = img;

            var video = {
                type: "video",
                display: "Video",
                img: ""
            }
            $scope.parameters[i++] = video;
            console.log("Created dummyParameters!");
            console.log($scope.parameters);
        }

    }
})();
