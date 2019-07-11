// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.ajax({
    url: '/Home/Action1',
    cache: false
})
.done(function (data) {
    $('#ajax1').html(data);
})
.fail(function () {
    $('#ajax1').html('ERROR');
});



$.ajax({
    url: '/Home/Action2',
    cache: false
})
.done(function (data) {
    $('#ajax2').html(data);
})
.fail(function () {
    $('#ajax2').html('ERROR');
});



$.ajax({
    url: '/Home/Action3',
    cache: false
})
.done(function (data) {
    $('#ajax3').html(data);
})
.fail(function () {
    $('#ajax3').html('ERROR');
});


