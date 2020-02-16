(function () {
    'use strict';
    var user = {};
    var app = angular.module('app', [
        'ngRoute'
    ])
        .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $locationProvider.hashPrefix('');
            $routeProvider
                .when('/', {
                    templateUrl: '/Web/templates/user.html',
                    controller: 'userCtrl'
                })
                .when('/addUser', {
                    controller: 'userAddCtrl',
                    templateUrl: '/Web/templates/userAdd.html'
                })
                .when('/editUser/:id', {
                    controller: 'userEditCtrl',
                    templateUrl: '/Web/templates/userEdit.html'
                })
                .otherwise({ redirectTo: '/' });

        }])

    app.controller('userCtrl', ['$scope', 'dataService', '$location', function ($scope, dataService, $location) {
        $scope.users = [];
        getData();

        function getUser(elt) {
            user = elt;
            console.log(user);
        }

        $scope.getUser = function (item) {
            getUser(item);
            window.location.href = '#/editUser/' + item.ID;
        };

        function getData() {
            dataService.getUsers().then(function (result) {
                $scope.users = result;
            });
        }
        $scope.deleteUser = function (id) {
            console.log(id)
            dataService.deleteUser(id).then(function () {
                console.log('success');
                getData();
            }, function () {
                console.log(Error);

            })
        }

       
    }])
    app.controller('userAddCtrl', ['$scope', '$location', 'dataService', function ($scope, $location, dataService) {
        $scope.createUser = function (user) {
            console.log(user);
            dataService.addUser(user).then(function () {
                $location.path('/');
            })
        }
    }])
    app.controller('userEditCtrl', ['$scope', '$routeParams', '$location', 'dataService', function ($scope, $routeParams, $location, dataService) {

        $scope.user = user;
        console.log($scope.user);
        //dataService.editUser($scope.user).then(function (result) {
            
        //    $scope.user = result;

        //})

        $scope.updateUser = function (user) {
            dataService.editUser(user).then(function () {
                $location.path('/');
            })
        }
    }])
    

    //.controller(userCtrl, test)
})();