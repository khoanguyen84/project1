var role = role || {};

role.drawTable = function () {
    $.ajax({
        url: '/Admin/Role/Gets',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                $('#tbRoles').empty();
                $.each(response, function (index, value) {
                    $('#tbRoles').append("<tr>" +
                        "<td>" + value.roleKey + "</td>" +
                        "<td>" + value.roleName + "</td>" +
                        "<td>" +
                        "<a href='javascript:void(0);' onclick=role.openEditModal('" + value.roleKey +"')><i class='fa fa-edit'></i></a> " +
                        "<a href='javascript:void(0);' onclick=role.delete('" + value.roleKey +"')><i class='fa fa-trash'></i></a> " +
                        "</td>" +
                        "</tr>");
                });
            }
        }
    });
};

role.save = function () {
    if ($('#frmAddEditRole').valid()) {
        var objRole = {};
        objRole["RoleKey"] = $("#RoleKey").val();
        objRole["RoleName"] = $("#RoleName").val();
        $.ajax({
            url: "/Admin/Role/Save",
            type: 'POST',
            data: JSON.stringify(objRole),
            contentType: 'application/json',
            datatype: 'json',
            success: function (data) {
                if (data.status === 1) {
                    $('#message').removeClass('alert-danger').addClass('alert-success');
                    $('#addEditModel').modal('hide');
                    role.resetForm();
                    role.drawTable();
                } else {
                    $('#message').removeClass('alert-success').addClass('alert-danger');
                }
                $('#message').html(data.message);
                $('#message').show();
            }
        });
    }  
};

role.openAddEditModal = function () {
    role.resetForm();
    $('#addEditModel').modal('show');
};

role.openEditModal = function (id) {
    $.ajax({
        url: "/Admin/Role/Get/" + id,
        type: 'POST',
        contentType: 'application/json',
        datatype: 'json',
        success: function (data) {
            if (data.status === 1) {
                role.resetForm();
                $('#addEditModel #RoleKey').val(data.response.roleKey);
                $('#addEditModel #RoleName').val(data.response.roleName);
                $('#addEditModel').modal('show');
            }
        }
    });
};

role.delete = function (id) {
    bootbox.confirm({
        message: "Are you sure to delete this role?",
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
                    url: '/Admin/Role/delete/' + id,
                    method: 'GET',
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {
                        if (data.status === 1) {
                            role.drawTable();
                        }
                    }
                });
            }
        }
    });
};

role.resetForm = function () {
    $("#RoleKey").val('');
    $("#RoleName").val('');
    $('#message').hide();
};

role.init = function () {
    role.drawTable();
    role.resetForm();
};
$(document).ready(function () {
    role.init();
});
