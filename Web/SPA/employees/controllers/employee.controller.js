(function () {
    'use strict';
    angular.module('tsi.employee').controller("employeesCtrl", ["$scope", "employeesService", employeesCtrl]);

    function employeesCtrl($scope, employeesService) {
        $scope.employees = [];

        employeesService.getAllEmployees().then(function (data) {
            $scope.employees = data;
        });
    }

})();