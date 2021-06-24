// let snake = [{ x: 200, y: 200 },
// { x: 180, y: 200 },
// { x: 160, y: 200 },
// { x: 140, y: 200 }];

// function getSnakeBoardStyles() {
//     const snakeBoard = document.getElementById("snakeCanvas");

//     return snakeBoard.getContext("2d");
// }

// //Horizontal
// let dx = 20;
// //Vertical
// let dy = 0;

// // main();

// export default function main(board) {
//     setTimeout(function onTick() {
//         DrawCanvas(board);
//         MoveSnake();
//         DrawSnake();
//         main(board);
//     }, 100)
// }

// function DrawCanvas(board) {
//     const snakeBoardStyles = getSnakeBoardStyles();
//     const snakeBoard = board.current;
//     snakeBoardStyles.fillStyle = "white";
//     snakeBoardStyles.strokeStyle = "lightred";
//     snakeBoardStyles.fillRect(0, 0, snakeBoard.width, snakeBoard.height);
//     snakeBoardStyles.strokeRect(0, 0, snakeBoard.width, snakeBoard.height);
// }

// function DrawSnake() {
//     snake.forEach(DrawSnakePart);
// }

// function DrawSnakePart(snakePart) {
//     const snakeBoardStyles = getSnakeBoardStyles();

//     snakeBoardStyles.fillStyle = "lightgreen";
//     snakeBoardStyles.strokeStyle = "black";
//     snakeBoardStyles.fillRect(snakePart.x, snakePart.y, 20, 20);
//     snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, 20, 20);
// }

// function MoveSnake() {
//     let head = { x: snake[0].x + dx, y: snake[0].y + dy };
//     snake.unshift(head);
//     snake.pop();
// }