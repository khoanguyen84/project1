$(document).on({
    ajaxStart: function () {
        $(".loader").show();
    },
    ajaxStop: function () {
        $(".loader").hide();
    },
    ajaxError: function () {
        $(".loader").hide();
    }
});