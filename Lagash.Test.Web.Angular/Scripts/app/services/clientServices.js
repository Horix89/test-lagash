app.factory('clientService', function ($http,$q) {
    var service = {
        createClient: createClient
    };
    return service;

    function createClient(params) {
        var result = $http({
            url: 'api/Client/Create',
            method: 'post',
            data: params
        });

        return $q.when(result);
    }   
});