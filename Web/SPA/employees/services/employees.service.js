(function () {
    'use strict';
    angular.module('tsi.employee').service('employeesService', ["$http", "$q", employeeService]);

    function employeeService($http, $q) {

        var getAllEmployees = function(){
            var defer = $q.defer();

            $http.get('api/employee')
	    	.success(function (employees) {
	    	    defer.resolve(employees);
	    	})
	    	.error(function(){
	    	    defer.reject('server error')
	    	});

            return defer.promise;
        };

        return {
            getAllEmployees : getAllEmployees
        }

    }

})();