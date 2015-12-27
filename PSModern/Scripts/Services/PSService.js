var PSService = function ($http) {

    this.GetAllWorks = function()
    {
        return $http.get("api/ps/GetAllWorks");
    }

    this.GetAllBNs = function()
    {
        return $http.get("api/ps/GetAllBNs");
    }

    this.GetAllResTypes = function () {
        return $http.get("api/ps/GetAllResTypes");
    }
}