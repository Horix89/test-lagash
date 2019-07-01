
var app = angular.module('lagashTestApp', []);
app.controller('homeController', function ($scope, $http, $location, $window, clientService) {
    $scope.client = {};
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;
    $scope.redirectUrl = "";

    //, $http, $location, $window
    ////get called when user submits the form
    $scope.submitForm = function () {
        $scope.isViewLoading = true;
        $scope.errors = [];
        clientService.createClient($scope.client).then(function (response) {
            $scope.client = {};
            $scope.message = 'Client Create';
            $scope.result = "color-green";
            $scope.isViewLoading = false;
        });        
    };
 
});