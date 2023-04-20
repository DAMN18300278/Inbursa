function iniciarFuncion(){
    setTimeout(function(){
        anime({
          targets: '#icon',
          strokeDashoffset: [anime.setDashoffset, 0],
          duration: 2000,
          easing: 'easeInOutSine',
          direction: 'alternate',
          loop: true
        });
      }, 200);
      document.getElementById('app').style.display = 'block';
      animateCSS('app', 'fadeInUp');
}

function cambiarPestaña(){
  document.getElementById('app').style.display = 'none';
  document.getElementById('app').style.display = 'block';
  animateCSS('app', 'fadeInUp');
}

setTimeout(iniciarFuncion, 700);

const animateCSS = (element, animation, prefix = 'animate__') =>
// We create a Promise and return it
new Promise((resolve, reject) => {
    const animationName = `${prefix}${animation}`;
    const node = document.getElementById(element);

    node.classList.add(`${prefix}animated`, animationName);

    // When the animation ends, we clean the classes and resolve the Promise
    function handleAnimationEnd(event) {
        event.stopPropagation();
        node.classList.remove(`${prefix}animated`, animationName);
        resolve('Animation ended');
    }

    node.addEventListener('animationend', handleAnimationEnd, {once: true});
});
