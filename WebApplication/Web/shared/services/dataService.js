(function () {
    'use strict';

    angular
        .module('app')
        .factory('dataService', ['$http', '$q', function ($http, $q) {
            var service = [];

            //function convertDate(inputFormat) {
            //    function pad(s) { return (s < 10) ? '0' + s : s; }
            //    var d = new Date(inputFormat)
            //    return [pad(d.getDate()), pad(d.getMonth() + 1), d.getFullYear()].join('/')
            //}

            service.getUsers = function () {
                var deferred = $q.defer();
                $http.get('/User/Index').then(function (result) {
                    console.log(result);
                    deferred.resolve(result.data);
                }, function () {
                        deferred.reject();
                
                });
                return deferred.promise;
            }
            service.addUser = function (user) {
                var deferred = $q.defer();
                $http.post('/User/Create', user).then(function () {
                    console.log(user)
                    deferred.resolve();
                }, function () {
                    deferred.reject();

                });
                return deferred.promise;
            }
            service.editUser = function (user) {
                var deferred = $q.defer();
                $http.post('/User/Update/', user).then(function () {
                    console.log(user)
                    deferred.resolve();
                }, function () {
                    deferred.reject();

                });
                return deferred.promise;
            }
            
            service.deleteUser = function (user) {
                var deferred = $q.defer();
                $http.post('/User/Delete/', user).then(function () {
                    
                    deferred.resolve();
                }, function () {
                    deferred.reject();

                });
                return deferred.promise;
            }
            return service;
        }])
        
    
})();