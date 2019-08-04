var productGroup = ['sonny','iphone','hopvitlon'];
let pos = 0;
function add(){
    productGroup.push(document.getElementById("txtValue").value);
    document.getElementById("txtValue").value = "";
    display();
}
function update(){
    productGroup[pos] = document.getElementById("txtValue").value;
    document.getElementById("txtValue").value = "";
    display();
}

function display(){
    let tbody = "";
    let i = 0;
    for(i = 0; i < productGroup.length; i++){
        tbody = tbody 
        +'<tr>'
            + '<td>'+ (i + 1) +'</td>'
            + '<td>' + productGroup[i] + '</td>'
            + '<td>'
                +'<input type="button" value ="Update" onclick="Update('+i+')" />&nbsp;&nbsp;' 
                +'<input type="button" value ="Delete" onclick="Delete('+i+')" />'
            + '</td>'
        +'</tr>';
    }
    document.getElementById("result").innerHTML = tbody;
}

function Delete(id) {
    productGroup.splice(id,1);
    display();
}

function Update(id) {
    document.getElementById("txtValue").value = productGroup[id];
    pos = id;
}

display();