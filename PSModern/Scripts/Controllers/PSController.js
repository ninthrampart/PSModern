var PSController = function ($scope, PSService) {
    //debugger;
    $scope.models = {
        helloAngular: 'I work!'

    };

    GetAllWorks();
    GetAllBNs();
    GetAllResTypes();
    //debugger;

    function GetAllWorks()
    {
        //debugger;
        var getData = PSService.GetAllWorks();
        getData.then(function (works) {
            debugger;
            $scope.models.WorkName = works.data[0].Name;
            $scope.models.Works = works.data;
            debugger;
        }, function (a, b, c) {
            debugger;
        });
    }

    function GetAllBNs()
    {
        var getData2 = PSService.GetAllBNs();
        getData2.then(function (bns) {
            //debugger;
            $scope.models.BNs = bns.data;
            //$scope.models.bn = null;
            //debugger;
        }, function (a, b, c) {
            debugger;
        });
    }

    function GetAllResTypes()
    {
        debugger;
        var getData3 = PSService.GetAllResTypes();
        getData3.then(function (rTypes) {
            debugger;
            $scope.models.ResTypes = rTypes.data;
            debugger;
        },
            function (a, b, c) {
                debugger;
            });
    }
}