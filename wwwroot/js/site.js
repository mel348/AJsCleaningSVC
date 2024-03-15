
$(function () {
    // Hide all service rows, description rows, and action rows initially
    $('tr.service-row, tr.description-row, tr.action-row').hide();

    // Handle click on type row to toggle service rows
    $('.toggle-service').on('click', function () {
        var typeRow = $(this).closest('tr.type-row');
        var serviceRows = typeRow.nextUntil('tr.type-row').filter('.service-row');

        // Check if service rows are currently visible
        var areServiceRowsVisible = serviceRows.is(':visible');

        // Hide all rows
        $('tr.service-row, tr.description-row, tr.action-row').hide();

        // Toggle visibility of service rows
        if (!areServiceRowsVisible) {
            serviceRows.show();
        }
    });

    // Handle click on service row to toggle description row and actions
    $('.toggle-description').on('click', function () {
        var serviceRow = $(this).closest('tr.service-row');
        var descriptionRow = serviceRow.next('.description-row');

        // Hide all description rows
        $('tr.description-row').not(descriptionRow).hide();

        // Get the description text and split it into a list based on dashes
        var descriptionText = descriptionRow.find('.description').data('description');
        var descriptionList = descriptionText.split('- ');

        // Clear existing content and create a list
        descriptionRow.find('.description').empty();
        var list = $('<ul>');

        // Filter out empty items from the description list
        descriptionList.forEach(function (item) {
            var trimmedItem = item.trim();
            if (trimmedItem !== '') {
                list.append($('<li>').text(trimmedItem));
            }
        });

        // Append the list only if it has items
        if (list.children().length > 0) {
            descriptionRow.find('.description').append(list);
        }

        // Toggle visibility of description row
        descriptionRow.toggle();
    });
});