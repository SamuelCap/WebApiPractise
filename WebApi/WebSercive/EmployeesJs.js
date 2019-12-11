/*$(document).ready(function () {
            var ulEmployees = $('#ulEmployees');
            $('#btn').click(function () {
        $.ajax({
            type: 'GET',
            url: "api/Employees/",
            dataType: 'json',
            success: function (data) {
                ulEmployees.empty();
                $.each(data, function (index, val) {
                    var fullName = val.firstName + ' ' + val.lastName;
                    ulEmployees.append('<li>' + fullName + '</li>');
                });
            }
        });
    });

    $('#btnClear').click(function () {
        ulEmployees.empty();
    });
});*/
function GetEmployees() {
    var ulEmployees = $('#ulEmployees');
    $.ajax({
        type: 'GET',
        url: "api/Employees/",
        dataType: 'json',
        success: function (data) {
            //ulEmployees.empty();
            $.each(data, function (index, val) {
                var fullName = val.firstName + ' ' + val.lastName;
                ulEmployees.append('<li>' + fullName + '</li>');
            });
        }
    });
}
function ClearFunc() {
    var ulEmployees = $('#ulEmployees');
    ulEmployees.empty();
}