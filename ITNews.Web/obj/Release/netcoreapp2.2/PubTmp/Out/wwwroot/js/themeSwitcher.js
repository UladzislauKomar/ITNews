function changeCSS(themeName, cssLinkIndex) {
    $.cookie('themeFlag', themeName, { path: '/' });
    location.reload();
}