const flower = document.querySelector('.flower');

for (let i = 0; i < 10; i++) {
  const petal = document.createElement('div');
  petal.classList.add('petal');
  petal.style.transform = `rotate(${i * 36}deg)`;
  flower.appendChild(petal);
}

const pistil = document.createElement('div');
pistil.classList.add('pistil');
flower.appendChild(pistil);
