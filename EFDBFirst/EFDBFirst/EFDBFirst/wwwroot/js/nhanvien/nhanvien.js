var nhanvien = nhanvien || {};


nhanvien.drawDataTable = function () {
    $("#tbNhanVien").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/NhanVien/Gets",
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
                "orderable": true
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
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-info" href="/NhanVien/get/' + data + '">Edit</a>' + ' ' + "<a href='#' class='btn btn-danger' onclick=DeleteEmployee('" + data + "'); >Delete</a>";
                },
                "title": "Actions",
                "orderable": false
            }
        ]

    }); 
};

nhanvien.showModal = function () {
    $('#addEditNhanVien').modal('show');
};

nhanvien.initSkill = function () {
    $.ajax({
        url: 'NhanVien/GetSkill',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#Skill').append(
                        "<option value=" + value.id + ">" + value.name + "</option>"
                    );
                });
            }
        }

    });
};

nhanvien.init = function () {
    nhanvien.initSkill();
    nhanvien.drawDataTable();
    
};

$(document).ready(function () {
    nhanvien.init();
});