var register = register || {};

register.save = function () {
    if ($('#frmRegister').valid()) {
        var objRegister = {};
        objRegister["Email"] = $("#Email").val();
        objRegister["Password"] = $("#Password").val();
        objRegister["ConfirmPassword"] = $("#ConfirmPassword").val();
        objRegister["Gender"] = $("#Gender").val();
        objRegister["DOB"] = $("#DOB").val();
        objRegister["Address"] = $("#Address").val();
        $.ajax({
            url: "/Account/Register",
            type: 'POST',
            data: JSON.stringify(objRegister),
            contentType: 'application/json',
            datatype: 'json',
            success: function (data) {
                if (data.status === 1) {
                    $('#message').removeClass('alert-danger').addClass('alert-success');
                    register.resetForm();
                } else {
                    $('#message').removeClass('alert-success').addClass('alert-danger');
                }
                $('#message').html(data.message);
                $('#message').show();
            }
        });
    }    
};

register.resetForm = function () {
    $("#Email").val('');
    $("#Password").val('');
    $("#ConfirmPassword").val('');
    $("#DOB").val('');
    $("#Address").val('');
};

register.init = function () {
    $('#message').hide();
};
$(document).ready(function () {
    register.init();
});
