// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$("#card").mouseover(function () {
//    $("#card2").css("visibility", "block");
//});

function myFunction(bookId) {
    var x = document.getElementById("card2-" + bookId)
    x.style.visibility = "visible"
}

function myFunction2(bookId) {
    var x = document.getElementById("card2-" + bookId)
    x.style.visibility = "hidden"
}