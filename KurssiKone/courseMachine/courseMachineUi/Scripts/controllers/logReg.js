(function () {
    'use strict';

    angular
        .module('course')
        .controller('logRegController', logReg);

    function logReg($scope) {
        if ($scope.loginBox == null || $scope.registerBox == null) {
            $scope.loginBox = true;
            $scope.registerBox = false;
            console.log("Resetted shows");
        }

        $scope.login = function () {
            $scope.loginBox = true;
            $scope.registerBox = false;
        }

        $scope.register = function () {
            $scope.loginBox = false;
            $scope.registerBox = true;
        }
    }
})();
