var user = user || {};
var addEditModal = $('#addEditModal');

user.drawDataTable = function () {
    $.ajax({
        url: 'User/GetUsers',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $('#tbUser').empty();
                $.each(response, function (index, value) {
                    $('#tbUser').append("<tr>" +
                        "<td>" + value.userName + "</td>" +
                        "<td>" + value.dob + "</td>" +
                        "<td>" + value.userMobile + "</td>" +
                        "<td>" + value.userEmail + "</td>" +
                        "<td>" + value.countryName + "</td>" +
                        "<td>" + value.jobName + "</td>" +
                        "<td>" +
                            "<a href ='javascript:void(0);' onclick='user.showEditModal(" + value.userId +")' > <i class='fas fa-edit'></i></a>" +
                            "<a href ='javascript:void(0);'> <i class='fas fa-trash-alt'></i></a>" +
                        "</td > " +
                        "</tr>");
                });
            }
        }
    });
};

user.showModal = function () {
    user.resetForm();
    $('#addEditModal').find(".modal-title").text("Add User");
    $('#addEditModal').modal('show');
};

user.save = function () {
    var objUser = {};
    objUser["UserName"] = $("#UserName").val();
    objUser["UserMobile"] = $("#UserMobile").val();
    objUser["UserEmail"] = $("#UserEmail").val();
    objUser["FaceBookUrl"] = $("#FaceBookUrl").val();
    objUser["LinkedInUrl"] = $("#LinkedInUrl").val();
    objUser["TwitterUrl"] = $("#TwitterUrl").val();
    objUser["PersonalWebUrl"] = $("#PersonalWebUrl").val();
    objUser["CountryId"] = $("#CountryId").val();
    objUser["JobId"] = $("#JobId").val();
    objUser["DOB"] = $("#DOB").val();
    $.ajax({
        url: "User/Save",
        type: 'POST',
        data: JSON.stringify(objUser),
        contentType: 'application/json',
        datatype: 'json',
        success: function (data) {
            if (data.status === 1) {
                $('#addEditModal').modal('hide');
                user.drawDataTable();
            }
        }
    });
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
                $('#CountryId').empty();
                $.each(response, function (index, value) {
                    $('#CountryId').append("<option value = " + value.id + ">" + value.countryName + "</option>");
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
                $('#JobId').empty();
                $.each(response, function (index, value) {
                    $('#JobId').append("<option value = " + value.id + ">" + value.jobName + "</option>");
                });
            }
        }
    });
};

user.resetForm = function () {
    $("#UserName").val('');
    $("#UserMobile").val('');
    $("#UserEmail").val('');
    $("#FaceBookUrl").val('');
    $("#LinkedInUrl").val('');
    $("#TwitterUrl").val('');
    $("#PersonalWebUrl").val('');
    $("#DOB").val('');
    $("#CountryId").prop('selectedIndex', 0);
    $("#JobId").prop('selectedIndex', 0);
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
                $("#UserName").val(response.userName);
                $("#UserMobile").val(response.userMobile);
                $("#UserEmail").val(response.userEmail);
                $("#FaceBookUrl").val(response.faceBookUrl);
                $("#LinkedInUrl").val(response.linkedInUrl);
                $("#TwitterUrl").val(response.twitterUrl);
                $("#PersonalWebUrl").val(response.personalWebUrl);
                $("#DOB").val(response.userName);
                $("#CountryId").prop('selectedIndex', response.countryId);
                $("#JobId").prop('selectedIndex', response.jobId);

                $('#addEditModal').find(".modal-title").text("Edit User");
                $('#addEditModal').modal('show');
            }
        }
    });
};

user.showConfirmDeleteModal = function (id) {
    BootstrapDialog.show({
        title: "Confirm",
        message: 'Are you sure to delete this user?',
        type: BootstrapDialog.TYPE_WARNING,
        buttons: [{
            label: 'Hủy',
            action: function (dialogItself) {
                dialogItself.close();
            }
        }, {
            label: 'Yes',
            cssClass: 'btn-primary',
            action: function (dialogItself) {
                //user.delete(id);
                dialogItself.close();
            }
        }]
    });
};


user.init = function () {
    user.initCountry();
    user.initJob();
    user.resetForm();
    user.drawDataTable();
};

$(document).ready(function () {
    user.init();
});