var user = user || {};

user.drawDataTable = function () {
    $.ajax({
        url: 'User/GetUsers',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $('#tbUsers').empty();
                $.each(response, function (index, value) {
                    $('#tbUsers').append("<tr>" +
                        "<td>" + value.userName + "</td>" +
                        "<td>" + value.dob + "</td>" +
                        "<td>" + value.userMobile + "</td>" +
                        "<td>" + value.userEmail + "</td>" +
                        "<td>" + value.countryName + "</td>" +
                        "<td>" + value.jobName + "</td>" +
                        "<td>" +
                            "<a href='javascript:void(0);' onclick='user.showEditModal("+value.userId+")'><i class='fas fa-edit'></i></a>" +
                            "<a href='javascript:void(0);'><i class='fas fa-trash-alt'></i></a>" +
                        "</td>" +
                        "</tr>");
                });
            }
        }
        
    });
};

user.showModal = function () {
    $('#addEditModal').modal('show');
};

user.initCountry = function () {
    $.ajax({
        url: 'User/GetCountry',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#Country').append(
                        "<option value=" + value.id + ">" + value.countryName+"</option>"
                    );
                });
            }
        }

    });
};

user.initJob = function () {
    $.ajax({
        url: 'User/GetJob',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#Job').append(
                        "<option value=" + value.id + ">" + value.jobName + "</option>"
                    );
                });
            }
        }

    });
};

user.save = function () {
    var userObj = {};
    userObj["UserName"] = $('#UserName').val();
    userObj["DOB"] = $('#DOB').val();
    userObj["UserMobile"] = $('#UserMobile').val();
    userObj["UserEmail"] = $('#UserEmail').val();
    userObj["CountryId"] = $('#Country').val();
    userObj["JobId"] = $('#Job').val();
    $.ajax({
        url: 'User/Save',
        method: 'POST',
        dataType: 'json',
        data: JSON.stringify(userObj), //convert obj to json
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                user.resetForm();
                $('#addEditModal').modal('hide');
                user.drawDataTable();
            }
        }

    });
};

user.resetForm = function () {
    $('#UserName').val('');
    $('#DOB').val('');
    $('#UserMobile').val('');
    $('#UserEmail').val('');
    $('#Country').prop('selectedIndex', 0);
    $('#Job').prop('selectedIndex', 0);
};

user.init = function () {
    user.initCountry();
    user.initJob();
    user.resetForm();
    user.drawDataTable();
};

user.showEditModal = function (id) {
    $.ajax({
        url: 'User/Get/' + id,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $('#UserName').val(response.userName);
                $('#DOB').val(response.dob);
                $('#UserMobile').val(response.userMobile);
                $('#UserEmail').val(response.userEmail);
                $('#Country').prop('selectedIndex', response.countryId);
                $('#Job').prop('selectedIndex', response.jobId);

                $('#addEditModal').find('.modal-title').text("Edit User");
                $('#addEditModal').modal('show');
            }
        }

    });
};

$(document).ready(function () {
    user.init();
});