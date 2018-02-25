(function () {
    'use strict';

    angular
        .module('course')
        .controller('configController', configController);

    function configController($scope, $location, configService) {
        configService.fetchConfig();
        console.log("tere");
        $location.search('target', name);
        $scope.url = $location.search().target;
        console.log($scope.url);
    }
})();
