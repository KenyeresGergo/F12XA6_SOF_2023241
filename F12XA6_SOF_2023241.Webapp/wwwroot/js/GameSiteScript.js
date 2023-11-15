﻿document.addEventListener('DOMContentLoaded', function () {
    const track = document.getElementById("image-track");

    window.onmousedown = e => {
        track.dataset.mouseDownAt = e.clientX;
    }

    window.onmousemove = e => {
        if (track.dataset.mouseDownAt === "0") return;

        const mouseDelta = parseFloat(track.dataset.mouseDownAt) - e.clientX,
            maxDelta = window.innerWidth / 2;
        const percentage = (mouseDelta / maxDelta) * -100,
            nextPercentage = parseFloat(track.dataset.prevPercentage) + percentage;

        track.dataset.percentage = Math.min(0, Math.max(nextPercentage, -100));

        track.style.transform = `translate(${nextPercentage}%, -50%)`;

        for (const image of track.getElementsByClassName("image")) {
            image.style.objectPosition = `${nextPercentage}% 50%`;
        }
    }

    window.onmouseup = () => {
        track.dataset.mouseDownAt = "0";
        track.dataset.prevPercentage = track.dataset.percentage;
    }
});
