(function () {
    'use strict';

    angular.module('courseApp', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/course', {
                templateController: 'Views/',
                controller: ''
            })
            .when('/course/hub', {
                templateController: '',
                controller: ''
            })
        })
})();