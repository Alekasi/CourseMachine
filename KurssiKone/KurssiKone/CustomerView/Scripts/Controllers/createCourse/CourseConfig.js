(function () {
    'use strict';

    angular
        .module('courseApp')
        .controller('CourseConfig', CourseConfig);

    function CourseConfig($scope, $http) {

        $scope.testData = [];
        $scope.createDummy = function () {

        }
    }
})();
