(function () {
    'use strict';
    angular.module('tsi.employee', ['ngRoute']);

    angular.module('tsi.employee').config(['$routeProvider', '$locationProvider', configFunction]);

    /*@ngInject*/
    function configFunction($routeProvider, $locationProvider, employeesCtrl) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false }).hashPrefix('!');

        // Routes
        $routeProvider
			.when("/", {
			    templateUrl: "/SPA/employees/views/employee.html",
			    controller: 'employeesCtrl',
			})
            .when("/Employees", {
                templateUrl: "/SPA/employees/views/employee.html",
                controller: 'employeesCtrl',
            })
            .when("/Employees/Index", {
                templateUrl: "/SPA/employees/views/employee.html",
                controller: 'employeesCtrl',
            }).otherwise({
                redirectTo: '/Employees/Index'
            });
    }
})();