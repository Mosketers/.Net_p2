(function () {
    'use strict';
    angular.module('tsi.employee').controller("employeesCtrl", ["$scope", "$timeout", "employeesService", "backendHubProxy", employeesCtrl]);

    function employeesCtrl($scope, $timeout, employeesService, backendHubProxy) {
        $scope.employees = [];
        $scope.showAlert = false;
        
        console.log('trying to connect to service')
        var employeeDataHub = backendHubProxy(backendHubProxy.defaultServer, 'pushEmployee');
        console.log('connected to service')

        employeeDataHub.on('addEmployee', function (data) {
            console.log('addEmployee', data);

            $scope.showAlert = true;

            employeesService.getAllEmployees().then(function (data) {
                $scope.employees = data;

                $timeout(function () {
                    $scope.showAlert = false;
                }, 2000);
            });

        });
        
        employeesService.getAllEmployees().then(function (data) {
            $scope.employees = data;
        });

        /*var connection = $.hubConnection();
        var employeeAlertHubProxy = connection.createHubProxy('pushEmployee');
        employeeAlertHubProxy.on('addEmployee', function (message) {
            console.log('New user Id: ' + message);
        });
        connection.start().done(function () {
            console.log('Session started');
        });*/
    }

})();