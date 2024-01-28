﻿document.addEventListener('DOMContentLoaded', function () {
    const track = document.getElementById("image-track");

    const handleOnDown = e => {
        track.dataset.mouseDownAt = e.clientX;

        if (!track.classList.contains('fullscreen'))
            toggleFullScreen();
    };

    const handleOnUp = () => {
        track.dataset.mouseDownAt = "0";
        track.dataset.prevPercentage = track.dataset.percentage;
    };

    const handleOnMove = e => {
        if (track.dataset.mouseDownAt === "0")
            return;

        const mouseDelta = parseFloat(track.dataset.mouseDownAt) - e.clientX,
            maxDelta = window.innerWidth / 2;

        const percentage = (mouseDelta / maxDelta) * -100,
            nextPercentageUnconstrained = parseFloat(track.dataset.prevPercentage) + percentage,
            nextPercentage = Math.max(Math.min(nextPercentageUnconstrained, 0), -100);

        track.dataset.percentage = nextPercentage;

        track.animate({
            transform: `translate(${nextPercentage}%, -50%)`
        }, { duration: 1200, fill: "forwards" });

        for (const image of track.getElementsByClassName("image"))
        {
            image.animate({
                objectPosition: `${100 + nextPercentage}% center`
            }, { duration: 1200, fill: "forwards" });
        }
    };

    const toggleFullScreen = () => {
        track.classList.toggle('fullscreen');
    };

    /* -- Had to add extra lines for touch events -- */
    window.onmousedown = e => handleOnDown(e);

    window.ontouchstart = e => handleOnDown(e.touches[0]);

    window.onmouseup = e => handleOnUp(e);

    window.ontouchend = e => handleOnUp(e.touches[0]);

    window.onmousemove = e => handleOnMove(e);

    window.ontouchmove = e => handleOnMove(e.touches[0]);


    function openFullscreen(imageSrc) {
        document.getElementById('fullscreenImg').src = imageSrc;
        document.getElementById('fullscreen').style.display = 'flex';
    }

    function closeFullscreen() {
        document.getElementById('fullscreen').style.display = 'none';
    }
});