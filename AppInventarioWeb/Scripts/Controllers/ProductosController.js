var app = angular.module('AppInventario', []);
app.controller('ProductosController', function ($http, $scope) {
    $http.get("api/Proveedores")
        .then(function (response) {
            // First function handles success
            $scope.proveedores = response.data;
        }, function (response) {
            // Second function handles error
            $scope.content = "Something went wrong";
        });
});