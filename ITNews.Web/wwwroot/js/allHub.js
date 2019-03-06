"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/allHub").build();

connection.on("Comment", function (userName, newsId, content, created) {
    var html = "<div class=\"container\"> \
                    <div class=\"row\"> \
                        <div class=\"col-md-2 col-lg-1\"> \
                            <div class=\"thumbnail\"><img class=\"img-responsive user-photo\" src=\"https://ssl.gstatic.com/accounts/ui/avatar_2x.png\" height=\"50\" width=\"50\"></div> \
                        </div > \
                        <div class=\"col-md-9 col-lg-10\"> \
                            <div class=\"panel panel-default\"> \
                                <div class=\"panel-heading\"> \
                                    <a href=\"/User/Profile?userName=\"" + userName + "><strong>" + userName + "</strong></a><span class=\"text-muted\"> commented at " + created + "</span> \
                                </div> \
                                <div class=\"panel-body\">" + content + "</div> \
                                <div> \
                                    <button type=\"button\" id=\"like\" class=\"btn btn-primary btn-sm likeClass\">Like</button> \
                                </div> \
                            </div> \
                        </div> \
                    </div> \
                </div>";

    $("#noComments").hide();
    $("#commentList").prepend(html);
});

connection.on("Like", function (userName, commentId) {
    $("#" + commentId + "-like").hide();
    var likebtn = "<button type=\"button\" class=\"btn btn - primary btn - sm\"disabled>Liked!</button>";
    $("#" + commentId).append(likebtn);
});

connection.on("Rate", function (userName, newsId, rating) {
    $(".likeNews").hide();
    $(".dislikeNews").hide();
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

$("#submitButton").on("click", function (event) {
    var content = $('textarea#content').val();
    var userName = document.getElementById("userName").innerHTML;
    var newsId = document.getElementById("newsId").innerHTML;
    var currentdate = new Date();
    var datetime = (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/" +
        + currentdate.getFullYear() + " "
        + currentdate.getHours() + ":"
        + currentdate.getMinutes() + ":"
        + currentdate.getSeconds();
    var created = datetime;
    connection.invoke("Comment", userName, newsId, content, created).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

$(".likeNews").on("click", function (event) {
    var userName = document.getElementById("userName").innerHTML;
    var newsId = document.getElementById("newsId").innerHTML;
    var rating = 1;
    connection.invoke("Rate", userName, newsId, rating).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

$(".dislikeNews").on("click", function (event) {
    var userName = document.getElementById("userName").innerHTML;
    var newsId = document.getElementById("newsId").innerHTML;
    var rating = 0;
    connection.invoke("Rate", userName, newsId, rating).catch(function (err) {
        return console.error(err.toString());
    });
});

var likeButtons = document.getElementsByClassName("likeClass");

$.each(likeButtons, function (index, value) {
    value.addEventListener("click", function (event) {
        var userName = document.getElementById("userName").innerHTML;
        var commentId = $(this).parent().parent().attr("id")
        connection.invoke("Like", userName, commentId).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });
});