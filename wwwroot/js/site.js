// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(function () {
    // Hide all service rows initially
    $('tr.service-row').hide();

    // Handle click on type row to toggle service rows
    $('tr.type-row').on('click', function () {
        $(this).nextUntil('tr.type-row').toggle();
    });
});
