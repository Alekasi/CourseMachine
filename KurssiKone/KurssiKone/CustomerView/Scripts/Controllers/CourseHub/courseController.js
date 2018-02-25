(function () {
    'use strict';

    angular
        .module('courseApp')
        .controller('hubController', courseController)

    function courseController($scope, $http) {
        $scope.page = {
            current: 0,
            total: 1,
            perPage: 20,
            goto: 0
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
                    "amount" : 25
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





        $scope.courses = [];
        $scope.hub = [];
        
        for (var i = 0; i < 12; i++) {
            $scope.courses.push({
                courseId: "courseId",
                courseName: "courseName",
                creator: "creator",
                company: "company",
                status: "status",
                created: "created",
                users: "users",
                img: { path: "", name: "" },
                information: { full: "Have you ever just wanted to iterate some 12ish boxes with javascript?", partial: "" },
                price: { amount: (i + 1) * 4, currency: "€" },

                duration: {duration : "14", unit: "Days", show: "true"}
            });
            $scope.courses[i].information.partial = $scope.courses[i].information.full.length > 120 ? $scope.courses[i].information.full.substring(0, 30) : $scope.courses[i].information.full;
            $scope.courses[i].information.partial += "...";
        }

    }
})();
