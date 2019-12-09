var user = user || {};

user.drawTable = function () {
    usertable = $("#tbUser").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/Admin/Dashboard/Gets",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "userName",
                "name": "UserName",
                "autoWidth": true,
                "title": "User Name"
            },
            {
                "data": "dob",
                "name": "DOB",
                "autoWidth": true,
                "title": "DOB"
            },
            {
                "data": "gender",
                "name": "Gender",
                "autoWidth": true,
                "title": "Gender"
            },
            {
                "data": "address",
                "name": "Address",
                "autoWidth": true,
                "title": "Address"
            },
            {
                "data": "roles",
                "name": "Roles",
                "autoWidth": true,
                "title": "Roles",
                "sortable" : false
            },
            {
                data: "userId",
                render: function (data, type, row) {
                    return "<a href='javascript:void(0);' onclick=user.getDetail('" + data + "')><i class='fa fa-edit'></i></a> " +
                        "<a href='javascript:void(0);' onclick=user.delete('" + data + "')><i class='fa fa-trash'></i></a> ";
                },
                "sortable": false
            },
        ]

    });
};

user.getDetail = function (id) {
    user.resetForm();
    $.ajax({
        url: '/Admin/Dashboard/Get/' + id,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                
                $('#UserName').val(response.userName);
                $('#DOB').val(response.dob);
                $('#Address').val(response.address);
                $('#UserId').val(response.userId);
                user.initGender(response.gender);
                user.initRoles(response.roles);
            }
            
            $('#addEditModel').find('.modal-title').text('Update User');
            $('#addEditModel').modal('show');
        }
    });
};

user.save = function () {
    if ($('#frmAddEditUser').valid()) {
        var userObj = {};
        userObj.UserName = $('#UserName').val();
        userObj.Gender = $('#Gender').val();
        userObj.DOB = $('#DOB').val();
        userObj.Address = $('#Address').val();
        userObj.UserId = $('#UserId').val();
        userObj.Roles = $('#Roles').val();

        $.ajax({
            url: '/Admin/Dashboard/Save',
            method: 'POST',
            data: JSON.stringify(userObj),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                if (data.status === 1) {
                    $('#addEditModel').modal('hide');
                    user.reloadTable();
                }
            }
        });
    }
};

user.initGender = function (selected) {
    $('#Gender').empty();
    $('#Gender').append("<option " + (selected === true ? 'selected' : '') + " value='true'>Male</option>" +
                        "<option " + (selected === false ? 'selected' : '') + " value='false'>Female</option>");
};

user.resetForm = function () {
    $('#UserName').val('');
    $('#DOB').val('');
    $('#Address').val('');
    $('#UserId').val('');
    user.initGender(true);
    $('#addEditModel').find('.modal-title').text('Create New User');
    user.initRoles();
    $("#frmAddEditUser").validate().resetForm();
};

user.reloadTable = function () {
    usertable.ajax.reload(null, false);
};

user.initRoles = function (roles) {
    $.ajax({
        url: '/Admin/Role/Gets',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                $("#Roles").empty();
                $.each(response, function (index, value) {
                    $("#Roles").append("<option " + ($.inArray(value.roleName, roles) !== -1 ? 'selected' : '') + " value=" + value.roleKey + " >" + value.roleName + "</option>");
                });
            }
        }
    });
    $("#Roles").select2();
};

user.openAddModel = function () {
    user.resetForm();
    $('#addEditModel #UserName').removeAttr('readonly');
    $('#addEditModel').modal('show');
};

user.delete = function (id) {
    bootbox.confirm({
        message: "Are you sure to delete this user?",
        buttons: {
            confirm: {
                label: 'Yes',
                className: 'btn-success'
            },
            cancel: {
                label: 'No',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: '/Admin/Dashboard/delete/' + id,
                    method: 'GET',
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {
                        if (data.status === 1) {
                            user.reloadTable();                        }
                    }
                });
            }
        }
    });
};

user.init = function () {
    user.drawTable();
    user.initGender(true);
    user.initRoles([]);
};
$(document).ready(function () {
    user.init();
});
