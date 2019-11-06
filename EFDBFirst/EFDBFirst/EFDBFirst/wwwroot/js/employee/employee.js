var employee = employee || { };

employee.drawDataTable = function() {
    $("#tbEmployee").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/Employee/Gets",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "employeeID",
                "name": "EmployeeID",
                "autoWidth": true,
                "title": "Employee ID",
                "searchable": true,
                "orderable" : true
            },
            {
                "data": "employeeName",
                "name": "EmployeeName",
                "autoWidth": true,
                "title": "Employee Name",
                "searchable": true,
                "orderable": true
            },
            {
                "data": "phoneNumber",
                "name": "PhoneNumber",
                "autoWidth": true,
                "title": "PhoneNumber",
                "searchable": true,
                "orderable": true
            },
            {
                "data": "skill",
                "name": "Skill",
                "autoWidth": true,
                "title": "Skill",
                "searchable": true,
                "orderable": true
            },
            {
                "data": "yearsExperience",
                "name": "YearsExperience",
                "autoWidth": true,
                "title": "YearsExperience",
                "orderable": true
            },
            {
                "data": "employeeID",
                "render": function(data, type, full, meta) {
                    return '<a class="btn btn-info" href="/Employee/get/' + data + '">Edit</a>' + ' ' + "<a href='#' class='btn btn-danger' onclick=DeleteEmployee('" + data + "'); >Delete</a>";
                },
                "title": "Actions",
                "orderable": false
            }
        ]

    });  
};

employee.init = function() {
    employee.drawDataTable();
};

$(document).ready(function() {
    employee.init();
});