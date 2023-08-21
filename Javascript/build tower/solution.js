// problem: https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/javascript

function towerBuilder(nFloors) {
  const tower = [];

  for (let i = 0; i < nFloors; i++) {
    const spaces = " ".repeat(nFloors - i - 1);
    const stars = "*".repeat(2 * i + 1);
    const floor = spaces + stars + spaces;
    tower.push(floor);
  }

  return tower;
}
