$(document).ready(function () {
    var $modal = $('.modal'),
        $modalOpenButton = $('.open-modal'),
        $modalCloseButton = $('.close-modal'),
        $nav = $('nav'),
        $wScroll = $(window).scrollTop(),
        $window = $(window),
        $openMobileNavigation = $('#open-mobile-navigation'),
        $mobileNavigation = $('.mobile-navigation'),
        $closeMobileNavigation = $('#close-mobile-navigation');

    if ($wScroll > $window.height() - 150) {
        $nav.addClass('is-scrolling');
    }

    $modal.on('click', function (event) {
        event.stopPropagation();
    });

    $mobileNavigation.on('click', function (event) {
        event.stopPropagation();
    });

    $modalOpenButton.on('click', function (event) {
        event.stopPropagation();
        $modal.addClass('is-active');
        event.preventDefault();
    });

    $openMobileNavigation.on('click', function (event) {
        event.stopPropagation();
        $mobileNavigation.addClass('is-active');
        event.preventDefault();
    });

    $modalCloseButton.on('click', function () {
        $modal.removeClass('is-active');
    });

    $closeMobileNavigation.on('click', function () {
        $mobileNavigation.removeClass('is-active');
    });

    $window.on('click', function () {
        if ($modal.hasClass('is-active')) {
            $modal.removeClass('is-active');
        }
        if ($mobileNavigation.hasClass('is-active')) {
            $mobileNavigation.removeClass('is-active');
        }
    });

    $('.banner-title').fitText(1.1, {minFontSize: '30px', maxFontSize: '72px'});

    var curPage = 1;
    var numOfPages = $(".skw-page").length;
    var animTime = 1000;
    var scrolling = false;
    var pgPrefix = ".skw-page-";

    function pagination() {
        scrolling = true;

        $(pgPrefix + curPage).removeClass("inactive").addClass("active");
        $(pgPrefix + (curPage - 1)).addClass("inactive");
        $(pgPrefix + (curPage + 1)).removeClass("active");

        setTimeout(function () {
            scrolling = false;
        }, animTime);
    }

    function navigateUp() {
        if (curPage === 1) return;
        curPage--;
        pagination();
    }

    function navigateDown() {
        if (curPage === numOfPages) return;
        curPage++;
        pagination();
    }

    $(document).on("mousewheel DOMMouseScroll", function (e) {
        if ($(window).width() < 768) return;
        if (scrolling) return;
        if (e.originalEvent.wheelDelta > 0 || e.originalEvent.detail < 0) {
            navigateUp();
        } else {
            navigateDown();
        }
    });

    $(document).on("keydown", function (e) {
        if ($(window).width() < 768) return;
        if (scrolling) return;
        if (e.which === 38) {
            navigateUp();
        } else if (e.which === 40) {
            navigateDown();
        }
    });
});