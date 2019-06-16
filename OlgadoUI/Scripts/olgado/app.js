//angular.module('olgadoApp', []).controller('olgadoController', function ($scope,$http) {
//    $scope.listaAnuncios = [];
//    $scope.listarAnuncios = function () {
//        $http.get('', function (dados)
//        {
//            console.log(dados);
//        });
//    };
//});

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
        if (e.keyCode === 13) {
            e.preventDefault();
            let descricao = $('#search').val();
            $http.get("http://localhost:49820/api/anuncio?Descricao=" + descricao)
                .then(function (response) {
                    let responseData = response.data;
                    $scope.listaAnuncios = responseData;

                });
        } else if (valor === '') {
            $scope.ListarAnuncios();
        }
    });

    $('#search').on('onChange',function () {
        console.log(this.val());
        if (this.val() === '') {
            $scope.ListarAnuncios();
        }
       
    });
});
