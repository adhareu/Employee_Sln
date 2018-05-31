assetApp.service("DepartmentService", ['$http', '$rootScope', function ($http, $rootScope) {
   
    this.headers = $rootScope.headersWithLog;
    this.noLogHeaders = $rootScope.headersWithoutLog;
    //get All Department  
    this.getAllDepartments = function () {
        return $http({
            method: 'GET',
            url: api + "Department/GetAllDepartment",
          
            headers: this.noLogHeaders
        });
      
    };
    this.getDepartment = function (Id) {
        return $http({
            method: 'GET',
            url: api + 'Department/GetDepartment',
            params: {
                Id: Encrypt.encrypt(Id)
            },
            headers: this.noLogHeaders
        });
    };
    // Adding Record  
    this.AddNewDepartment = function (tbl_Department) {
        return $http({
            method: "post",
            url: api + "Department/AddDepartment",
            data: JSON.stringify(tbl_Department),
            headers: this.noLogHeaders,
            dataType: "json"
        });
    }
    // Updating record  
    this.UpdateDepartment = function (tbl_Department) {
        return $http({
            method: "PUT",
            url: api + "Department/UpdateDepartment",
            data: JSON.stringify(tbl_Department),
            headers: this.noLogHeaders,
            dataType: "json"
        });
    }
    // Deleting records  
    this.deleteDepartment = function (Id) {
        return $http({
            method: "PUT",
            url: api + "Department/DeleteDepartment",
            params: {
                Id: Encrypt.encrypt(Id)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });
       
    }
    this.IsDepartmentExists = function (name) {
       
        return $http({
            method: "GET",
            url: api + "Department/IsDepartmentExists",
            params: {
                Name: Encrypt.encrypt(name)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });
       
    };
    this.IsDepartmentExists = function (id,name) {

        return $http({
            method: "GET",
            url: api + "Department/IsDepartmentExists",
            params: {
                id: Encrypt.encrypt(id),
                Name: Encrypt.encrypt(name)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });

    };
}]);