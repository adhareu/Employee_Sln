assetApp.controller("DepartmentControllerEdit", function ($scope, $location, DepartmentService) {

    $scope.Department = {};
    //Get Student INformation By Id

    var Id = $location.search()["id"];
    DepartmentService.getDepartment(Id).then(function (response) {

        $scope.Department = response.data;
    }).catch(function () { alert('Error in getting records'); });


    $scope.IsDepartmentExists = function () {

        DepartmentService.IsDepartmentExists(Id, $scope.Department.DepartmentName).then(function (response) {

            $scope.IsDuplicate = response.data;
        }).catch(function () { alert('Error in getting records'); });
    }
    // Updateing Records  
    $scope.UpdateDepartment = function (tbl_Department) {
        tbl_Department.ModifiedOn = getClientSideDateTime();
        tbl_Department.ModifiedBy = 1;
        var RetValData = DepartmentService.UpdateDepartment(tbl_Department);
        RetValData.then(function (msg) {
            
                alert('Updated Successfully');


        }).catch(function () {
            alert('Error in getting records');
        });
    }


});