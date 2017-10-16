(function () {
    'use strict';

    angular
        .module('Nidan')
        .factory('SessionService', SessionService);

    SessionService.$inject = ['$http'];

    function SessionService($http) {
        var service = {
            retrieveSessions: retrieveSessions
            //canDeleteSession: canDeleteSession,
            //deleteSession: deleteSession,
            //searchSession: searchSession
        };

        return service;

        function retrieveSessions(Paging, OrderBy) {

            var url = "/Subject/SessionList",
                data = {
                    paging: Paging,
                    orderBy: new Array(OrderBy)
                };

            return $http.post(url, data);
        }
    }
})();