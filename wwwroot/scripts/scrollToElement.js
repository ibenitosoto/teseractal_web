    function scrollToElement(elementId) {
        var element = document.getElementById(elementId);
    if (element) {
            var offsetTop = element.offsetTop;
    var windowHeight = window.innerHeight;
    var targetHeight = element.offsetHeight;

    var scrollTo = offsetTop - (windowHeight - targetHeight) / 2;

    window.scrollTo({
        top: scrollTo,
    behavior: 'smooth'
            });
        }
    }
