$(document).on("ready", function () {
    init();
});

function init() {
    $("#buttonC").on("click", function () {
        getClients();
    });
}

function getClients() {
    $.ajax({
        url: "/api/Customer/GetClients",
        type: 'POST',
        datatype: 'JSON',
        success: function (data) {            
        }
    });
}
