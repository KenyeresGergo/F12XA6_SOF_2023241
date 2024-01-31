document.addEventListener('DOMContentLoaded', function () {
    function openFullscreen(imageSrc) {
        document.getElementById('fullscreenImg').src = imageSrc;
        document.getElementById('fullscreen').style.display = 'flex';
    }

    function closeFullscreen() {
        document.getElementById('fullscreen').style.display = 'none';
    }

    // Attach click event to each image in the gallery
    const galleryImages = document.getElementsByClassName('image');
    Array.from(galleryImages).forEach(function (image) {
        image.addEventListener('click', function () {
            const imageSrc = image.src;
            openFullscreen(imageSrc);
        });
    });

    document.getElementById('fullscreenClose').addEventListener('click', closeFullscreen);
});
