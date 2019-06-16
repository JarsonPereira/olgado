var app = angular.module('olgadoApp', []);
app.controller('olgadoController', function ($scope, $http) {


    $scope.ListarAnuncios = function () {
        $http.get("http://localhost:49820/api/anuncio?Nome")
            .then(function (response) {
                let responseData = response.data;
                $scope.listaAnuncios = responseData;
                console.log(responseData);
            });
    };

    $('#search').on('keypress', function (e) {
        let valor = $(this).val();
        valor = valor === '' || valor === null ? '' : valor;
        $http.get("http://localhost:49820/api/anuncio?Descricao=" + valor)
            .then(function (response) {
                let responseData = response.data;
                $scope.listaAnuncios = responseData;

            });
    });

   

    
});
