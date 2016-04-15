(function () {
    'use strict';
    angular.module('tsi.employee').controller("employeesCtrl", ["$scope", "employeesService", employeesCtrl]);

    function employeesCtrl($scope, employeesService) {
        $scope.employees = [];

        employeesService.getAllEmployees().then(function (data) {
            console.log('service data', data);

            $scope.employees = data;
        });
    }

})();