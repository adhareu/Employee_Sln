
assetApp.controller("DepartmentControllerList", function ($scope, DepartmentService, DTOptionsBuilder) {
    
    $scope.Department = {};
    $scope.Departments = [];
  

   
    
    //To Get All Records  
  
       
    DepartmentService.getAllDepartments().then(function (Department) {
        $scope.Departments = Department.data;
    }).catch(function () {
        alert('Error in getting records');
    });
    
    
   
    
   
    // Deleting record.  
    $scope.deleteDepartment = function (Department, index) {
        var retval = DepartmentService.deleteDepartment(Department.StudentId).then(function (msg) {
            
        }).catch(function () {
            alert('Oops! something went wrong.');
        });
    }
   

    $scope.dtOptions = DTOptionsBuilder.newOptions()
                .withPaginationType('full_numbers')
                .withDisplayLength(2);
});
