var student = student || {};

student.drawTable = function () {
    $.ajax({
        url: '/Home/Gets',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#tbStudent').append("<tr>" +
                        "<td>"+ value.studentId +"</td>" +
                        "<td>"+ value.fullName +"</td>" +
                        "<td>"+ value.sex +"</td>" +
                        "<td>"+ value.dob +"</td>" +
                        "<td>"+ value.className + "</td>" +
                        "<td>" +
                            "<a href='javascript:void(0);' class='btn btn-dark'>Edit</a> " +
                            "<a href='javascript:void(0);' class='btn btn-danger'>Delete</a> " +
                        "</td>" +
                        "</tr>");
                });
            }
        }
    });
};

student.openAddEditModal = function () {
    $('#addEditModel').modal('show');
};

student.initClasses = function () {
    $.ajax({
        url: '/Home/GetClasses',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#ClassName').append(
                        "<option value = '"+ value.id +"'>"+ value.name +"</option>"
                    );
                });
            }
        }
    });
};

student.initSex = function () {
    $('#Sex').append(
        "<option value = '1'>Male</option><option value = '0'>Female</option>"
    );
};

student.save = function () {
    var studentObj = {};
    studentObj.FullName = $('#Fullname').val();
    studentObj.Sex = $('#Sex').val();
    studentObj.DOB = $('#DOB').val();
    studentObj.ClassRoomId = $('#ClassName').val();

    $.ajax({
        url: '/Home/Save',
        method: 'POST',
        data : JSON.stringify(studentObj),
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                $('#addEditModel').modal('hide');
                window.location.href = "/Home/Index";
            }
        }
    });
};

student.init = function () {
    student.drawTable();
    student.initClasses();
    student.initSex();
};

$(document).ready(function () {
    student.init();
});