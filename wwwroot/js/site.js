// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function () {
// Automatic Slideshow - change image every 3 seconds
    var myImagesAr = [
        "Dan_Bull.jpg",
        "Powerwolf.jpg",
        "StuckInTheSound.jpg",
        "TheLivingTombstone.jpg"
        ];

    var imageCount = 0;
    imgChange();

    setInterval(imgChange, 5000)

    function imgChange() {
        document.getElementById("myImages").setAttribute("src", "Images/" + myImagesAr[imageCount])
        imageCount++;

        if (imageCount === myImagesAr.length)
            imageCount = 0;
    }
})()
