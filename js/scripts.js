/*!
* Start Bootstrap - Clean Blog v6.0.8 (https://startbootstrap.com/theme/clean-blog)
* Copyright 2013-2022 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-clean-blog/blob/master/LICENSE)
*/ async function loadTemplateLayout() { var a = $("#index").text(); "0" == a ? (await $("#navigation-0").load("shared/navigation-0.html"), await $("#footer").load("shared/footer.html"), await $("#postPreview").load("shared/post-preview.html")) : "1" == a ? (await $("#navigation-1").load("../shared/navigation-1.html"), await $("#footer").load("../shared/footer.html"), await $("#postPreview").load("../shared/post-preview.html")) : "2" == a ? (await $("#navigation-2").load("../../shared/navigation-2.html"), await $("#footer").load("../../shared/footer.html"), await $("#postPreview").load("../../shared/post-preview.html")) : "3" == a && (await $("#navigation-3").load("../../../shared/navigation-3.html"), await $("#footer").load("../../../shared/footer.html"), await $("#postPreview").load("../../../shared/post-preview.html")); var t = document.title; $(document).attr("title", "Code-Bite | " + t), console.log("------------------\n< Happy Reading! >\n------------------\n        \\   ^__^\n         \\  (oo)\\_______\n            (__)\\       )\\/\\\n                ||----w |\n                ||     ||") } async function loadNav() { let a = 0, t = $("#mainNav")[0], i = t.clientHeight; window.addEventListener("scroll", function () { let e = -1 * document.body.getBoundingClientRect().top; e < a ? e > 0 && t.classList.contains("is-fixed") ? t.classList.add("is-visible") : t.classList.remove("is-visible", "is-fixed") : (t.classList.remove(["is-visible"]), e > i && !t.classList.contains("is-fixed") && t.classList.add("is-fixed")), a = e }) } window.addEventListener("DOMContentLoaded", () => { loadTemplateLayout() }), $(window).on("load", function () { setTimeout(() => { loadNav() }, 1) });