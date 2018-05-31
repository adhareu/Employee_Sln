assetApp.controller("DepartmentControllerAdd", function ($scope, DepartmentService) {
    
   
    
   
    
    $scope.IsDepartmentExists = function () {
       
        DepartmentService.IsDepartmentExists($scope.Department.DepartmentName).then(function (response) {
           
            $scope.IsDuplicate= response.data;
        }).catch(function () { alert('Error in getting records'); });
    }
  
    // Adding New student record  
    $scope.AddDepartment = function (Department) {
       
        Department.CreatedOn = getClientSideDateTime();
        Department.CreatedBy = 1;
        DepartmentService.AddNewDepartment(Department).then(function (msg) {
            alert('Added Successfully');
        }).catch( function () {
            alert('Error in adding record');
        });
    }
   
   

    
});