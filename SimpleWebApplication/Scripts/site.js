
var app = angular.module('sampleApplication', []);
app.controller('companyCtrl', function ($scope, $http) {

    function get() {
        $http.get("/api/companyapi")
            .then(function (response) {
                $scope.companies = response.data;
            });
    }

    function getCountry() {
        $http.get("/api/countryapi")
            .then(function (response) {
                $scope.chooseCountries = response.data;
                $scope.countryId = $scope.chooseCountries[0].id;
            });
    }

    getCountry();
    get();

    $scope.sendPost = function () {
        $scope.status = false;

        var data = JSON.stringify({
            Name: $scope.name,
            CountryId: $scope.countryId
        });

        $http.post("/api/companyapi/", data).success(function (data, status) {
            $scope.status = true;
            get();
        });
    }
});

