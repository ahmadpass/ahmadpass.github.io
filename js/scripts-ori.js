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
        await $("#navigation").load("shared/navigation-0.html");
        await $("#footer").load("shared/footer.html");
        await $("#postPreview").load("shared/post-preview.html");
        await $("#arrowup").load("shared/arrow-up-0.html");
    } else if (index == "1") {
        await $("#navigation").load("../shared/navigation-1.html");
        await $("#footer").load("../shared/footer.html");
        await $("#postPreview").load("../shared/post-preview.html");
        await $("#arrowup").load("../shared/arrow-up-1.html");
    } else if (index == "2") {
        await $("#navigation").load("../../shared/navigation-2.html");
        await $("#footer").load("../../shared/footer.html");
        await $("#postPreview").load("../../shared/post-preview.html");
        await $("#arrowup").load("../../shared/arrow-up-2.html");
    } else if (index == "3") {
        await $("#navigation").load("../../../shared/navigation-3.html");
        await $("#footer").load("../../../shared/footer.html");
        await $("#postPreview").load("../../../shared/post-preview.html");
        await $("#arrowup").load("../../../shared/arrow-up-3.html");
    }


    // Function for arrow up ======================================
    // // Get the button
    // let mybutton = document.getElementById("myBtn");

    // // When the user scrolls down 20px from the top of the document, show the button
    // window.onscroll = function () { scrollFunction() };

    // function scrollFunction() {
    //     if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
    //         mybutton.style.display = "block";
    //     } else {
    //         mybutton.style.display = "none";
    //     }
    // }

    // When the user clicks on the button, scroll to the top of the document
    // ===========================================================


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

function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

async function loadNav() {
    let mybutton = document.getElementById("myBtn");
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

        // For arrow up functionality
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            mybutton.style.display = "block";
        } else {
            mybutton.style.display = "none";
        }
    });
};

// window.addEventListener('DOMContentLoaded', () => {
//     loadNav();
// })

$(window).on('load', function () {
    setTimeout(() => {
        loadNav();
        topFunction();
    }
        , 1);
});

// for security, compress the ori javascript here before being use: http://javascriptcompressor.com/