
'use strict';
angular.module('tsi.employee').factory('backendHubProxy', ['$rootScope', 
  function ($rootScope) {

      function backendFactory(serverUrl, hubName) {
          var connection = $.hubConnection('http://localhost:64282');
          var proxy = connection.createHubProxy(hubName);

          connection.start().done(function () {
              console.log('conection start')
          });

          return {
              on: function (eventName, callback) {
                  proxy.on(eventName, function (result) {
                      $rootScope.$apply(function () {
                          if (callback) {
                              callback(result);
                          }
                      });
                  });
              },
              invoke: function (methodName, callback) {
                  proxy.invoke(methodName)
                  .done(function (result) {
                      $rootScope.$apply(function () {
                          if (callback) {
                              callback(result);
                          }
                      });
                  });
              }
          };
      };

      return backendFactory;
  }]);