(function () {
    'use strict';
    angular.module('tsi.employee').controller("employeesCtrl", ["$scope", "employeesService", "backendHubProxy", employeesCtrl]);

    function employeesCtrl($scope, employeesService, backendHubProxy) {
        $scope.employees = [];
        /*
        console.log('trying to connect to service')
        var employeeDataHub = backendHubProxy(backendHubProxy.defaultServer, 'pushEmployee');
        console.log('connected to service')

        employeeDataHub.on('addEmployee', function (data) {
            console.log('data', data)
        });
        */
        employeesService.getAllEmployees().then(function (data) {
            $scope.employees = data;
        });

        var connection = $.hubConnection();
        var employeeAlertHubProxy = connection.createHubProxy('pushEmployee');
        employeeAlertHubProxy.on('addEmployee', function (message) {
            console.log('New user Id: ' + message);
        });
        connection.start().done(function () {
            console.log('Session started');
        });
    }

})();