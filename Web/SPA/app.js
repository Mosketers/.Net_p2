(function () {

    angular.module('tsi', [
        'ngRoute',
        // Custom modules 
        'tsi.employee'
    ]);

    angular.module('tsi').config(['$routeProvider', '$locationProvider', configFunction]);

    /*@ngInject*/
    function configFunction($routeProvider, $locationProvider) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false }).hashPrefix('!');

        // Routes
        $routeProvider
			.when("/", {
			    templateUrl: "/SPA/employees/views/employee.html",
			    constroller: 'employeesCtrl',
			    controllerAs: 'employeesCtrl',
			})
            .when("/Employees", {
                templateUrl: "/SPA/employees/views/employee.html",
                constroller: 'employeesCtrl',
                controllerAs: 'employeesCtrl',
            })
            .when("/Employees/Index", {
                templateUrl: "/SPA/employees/views/employee.html",
                constroller: 'employeesCtrl',
                controllerAs: 'employeesCtrl',
            }).otherwise({
                redirectTo: '/Employees/Index'
            });
    }
})();