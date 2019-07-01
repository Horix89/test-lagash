$(document).on("ready", function () {
    init();
});

function init() {
    $("#buttonC").on("click", function () {
        getCustomers();
    });
}

function getCustomers() {
    $.ajax({
        url: "/api/customers/get",
        type: 'POST',
        datatype: 'JSON',
        success: function (data) {     
            var customers = data; 
            alert(JSON.stringify(data));
        }
    });
}
