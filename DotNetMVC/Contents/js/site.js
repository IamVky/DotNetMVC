//Navbar: add class 'active' based on menu selection
$(document).ready(function () {
    $('ul.navbar-nav').find('a[href="' + location.pathname + '"]').closest('li').addClass('active');
});