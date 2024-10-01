/*!
* Start Bootstrap - Clean Blog v6.0.8 (https://startbootstrap.com/theme/clean-blog)
* Copyright 2013-2022 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-clean-blog/blob/master/LICENSE)
*/

// $(document).ready(function () {
//     // Handler for .ready() called.
//     loadTemplateLayout();
// });

window.addEventListener('DOMContentLoaded', () => {
    loadTemplateLayout();

});

async function loadTemplateLayout() {
    var index = $('#index').text();

    if (index == "0") {
        await $("#navigation").load("shared/navigation.html");
        await $("#footer").load("shared/footer.html");
        await $("#postPreview").load("shared/post-preview.html");
    } else {
        await $("#navigation").load("../shared/navigation.html");
        await $("#footer").load("../shared/footer.html");
        await $("#postPreview").load("../shared/post-preview.html");
    };



    var currTitle = document.title;
    var baseTitle = "Code-Bite | ";
    $(document).attr("title", baseTitle + currTitle);

    var intermezzo =
        '------------------\n' +
        '< Happy Reading! >\n' +
        '------------------\n' +
        '        ' + '\\   ^__^\n' +
        '         ' + '\\  (oo)\\_______\n' +
        '            ' + '(__)\\       )\\/\\\n' +
        '                ' + '||----w |\n' +
        '                ' + '||     ||';

    console.log(intermezzo);
};

async function loadNav() {
    let scrollPos = 0;
    // const mainNav = document.getElementById('mainNav');
    const mainNav = $('#mainNav')[0];
    const headerHeight = mainNav.clientHeight;
    window.addEventListener('scroll', function () {
        const currentTop = document.body.getBoundingClientRect().top * -1;
        if (currentTop < scrollPos) {
            // Scrolling Up
            if (currentTop > 0 && mainNav.classList.contains('is-fixed')) {
                mainNav.classList.add('is-visible');
            } else {
                // console.log(123);
                mainNav.classList.remove('is-visible', 'is-fixed');
            }
        } else {
            // Scrolling Down
            mainNav.classList.remove(['is-visible']);
            if (currentTop > headerHeight && !mainNav.classList.contains('is-fixed')) {
                mainNav.classList.add('is-fixed');
            };
        }
        scrollPos = currentTop;
    });
};

// window.addEventListener('DOMContentLoaded', () => {
//     loadNav();
// })

$(window).on('load', function () {
    setTimeout(() => {
        loadNav();
    }
        , 1);
});

// for security, compress the ori javascript here before being use: http://javascriptcompressor.com/