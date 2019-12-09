var login = login || {};

login.signin = function () {
    if ($('#frmLogin').valid()) {
        var objLogin = {};
        objLogin["Email"] = $("#Email").val();
        objLogin["Password"] = $("#Password").val();
        objLogin["RememberMe"] = $("#RememberMe").is(':checked');
        $.ajax({
            url: "/Account/Login",
            type: 'POST',
            data: JSON.stringify(objLogin),
            contentType: 'application/json',
            datatype: 'json',
            success: function (data) {
                if (data.status === 1) {
                    window.location.href = "/Admin/Dashboard/";
                } else {
                    $('#message').removeClass('alert-success').addClass('alert-danger');
                    $('#message').html(data.message);
                    $('#message').show();
                }
            }
        });
    }
    
};

login.resetForm = function () {
    $("#Email").val('');
    $("#Password").val('');
};

login.init = function () {
    $('#message').hide();
};
$(document).ready(function () {
    login.init();
});
