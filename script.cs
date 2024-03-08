const petals = document.querySelectorAll('.petal');

function randomizeFlicker() {
  petals.forEach(petal => {
    let randomDelay = Math.random() * 0.5; // Up to 0.5s delay
    petal.style.animationDelay = `${randomDelay}s`;
  });
}

setInterval(randomizeFlicker, 2000); // Change flicker pattern every 2s
