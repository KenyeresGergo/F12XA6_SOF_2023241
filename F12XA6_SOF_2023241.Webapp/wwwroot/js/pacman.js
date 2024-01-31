document.addEventListener('DOMContentLoaded', function () {
    $(document).ready(function () {
        // Function to update pacman position
        function updatePacmanPosition() {
            var selectedPage = $('input[name="dots"]:checked').attr('id').split('-')[1];
            $('.pacman').css('transform', 'translateX(calc(var(--ddim) + (var(--rdim) * ' + selectedPage + ')))');
        }

        // Retrieve the last selected page from local storage
        var lastSelectedPage = localStorage.getItem('selectedPage');

        // Set the initial selected page or default to 0 if not found
        var initialPage = parseInt(lastSelectedPage, 10) + 1 || 1; // Add 1 here

        // Set the initial selected page and update pacman position
        $('#dot-' + (initialPage - 1)).prop('checked', true); // Subtract 1 here
        updatePacmanPosition();

        // Handle radio button change
        $('input[name="dots"]').change(function () {
            var selectedPage = $('input[name="dots"]:checked').attr('id').split('-')[1];

            // Save the selected page to local storage
            localStorage.setItem('selectedPage', selectedPage);

            // Update pacman position
            updatePacmanPosition();

            // Redirect to the new page
            window.location.href = '?page=' + (parseInt(selectedPage, 10) + 1); // Add 1 here
        });
    });
});
