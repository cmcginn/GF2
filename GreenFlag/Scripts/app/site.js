$(function () {
    if ($('#bannerImageRotator').length) {

        $('#bannerImageRotator').flexslider({
            animation: "fade",
            controlNav: false,
            directionNav: false,
            touch: true,
            direction: "vertical",
            animationSpeed: 1600
        });
    }
})