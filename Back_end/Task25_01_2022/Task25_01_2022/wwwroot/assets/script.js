
var myNav = document.getElementById("nav");

window.onscroll = function() {
  if (document.body.scrollTop >= 120 || document.documentElement.scrollTop >= 120 ) {
    myNav.classList.add("nav_colored");
    myNav.classList.remove("nav_transparent");
  } else {
    myNav.classList.add("nav_transparent");
    myNav.classList.remove("nav_colored");
  }
};
