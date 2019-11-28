var user = user || {};

user.drawTable = function(){
    $.ajax({
        url:'https://randomuser.me/api',
        method : 'GET',
        dataType : 'json',
        contentType : 'application/json',
        success : function(data){
            var response = data.results;
            $.each(response, function(index, value){
                var name = value.name;
                var location = value.location;

                $('#tbUser').append(
                    "<tr>"+
                        "<td>"+ name.title + "." + name.first + " " + name.last + "</td>" +
                        "<td>" + value.gender + "</td>" +
                        "<td>" + value.dob.date + "</td>" +
                        "<td>" + location.street.number + "-" + location.street.name+ "</td>" +
                        "<td>" + location.city + "</td>" +
                        "<td>" + location.state + "</td>" +
                        "<td>" + location.country + "</td>" +
                        "<td>" + location.postcode + "</td>" +
                        "<td>" + 
                            "<a href='javascript:;'><i class='fa fa-eye'></i></a>" +
                            "<a href='javascript:;' ><i class='fa fa-trash'></i></a>" +
                        "</td>" +
                    "</tr>");
            });
        }
    });
};

user.openAddEditUser = function(){
    $('#addEditUser').modal('show');
};

user.save = function(){
    if($('#frmAddEditUser').valid()){
        
    }
}

user.init = function() {
    user.drawTable();
};


$(document).ready(function(){
    user.init();
});