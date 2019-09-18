$(document).ready(function () {
    $("#editButton").on("click", function () {
        $("#profile").hide();
        $("#editProfile").show();
    });
    $("#cancelButton").on("click", function () {
        $("#editProfile").hide();
        $("#profile").show();
    });
});