//(function () {
//    'use strict';

//    angular
//        .module('app')
//        .controller('userCtrl', ['$scope', 'dataService', function ($scope,dataService) {
//            $scope.users = [];
//            getData();

//            function getData() {
//                dataService.getUsers().then(function (result) {
                    
//                    $scope.users = result;
//                });
//            }
//        }])
//        .controller('userAddCtrl', ['$scope', '$location', 'dataService', function ($scope, $location, dataService) {
//            $scope.createUser = function (user) {
//                dataService.addUser(user).then(function () {
//                    $location.path('/');
//                })
//            }
//        }])      
//})